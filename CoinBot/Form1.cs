using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLSharp.Core;
using TeleSharp.TL.Updates;
using TeleSharp.TL.Messages;
using TeleSharp.TL;
using Telegram.Bot;
using Bittrex.Net;
using Bittrex.Net.Objects;
using CoinBot.Class;
using System.Threading;

namespace CoinBot
{
    

    public partial class Form1 : Form
    {
        public static BittrexApiResult<BittrexCurrency[]> Currencies;
        bool runBittrexBot;
        bool runTelegramBot;
        
        public Form1()
        {
            InitializeComponent();
            SetStartupSettings();
        }

        public void SetStartupSettings()
        {
            if (Settings.Default.TelegramPhoneNumber != "")
            {
                SettingsgroupBox.Visible = false;
                LoggroupBox.Visible = TelegramgroupBox.Visible = BittrexgroupBox.Visible = true;
                BittrexSecrettextBox.Text = Settings.Default.BittrexApiSecret;
                BittrexKeytextBox.Text = Settings.Default.BittrexApiKey;
                telegramHashtextBox.Text = Settings.Default.TelegramApiHash;
                telegramKeytextBox.Text = Settings.Default.TelegramApiId.ToString();
                telegramPhonetextBox.Text = Settings.Default.TelegramPhoneNumber;
            }
            else
            {
                SettingsgroupBox.Visible = true;
                LoggroupBox.Visible = TelegramgroupBox.Visible = BittrexgroupBox.Visible = false;
            }
        }

        private async void StartBot_Click(object sender, EventArgs e)
        {
            try
            {
                await RunTelegramBotAsync();
            }
            catch (Exception ex)
            {
                AddLog("Klaida gaunant signalus:  ", ex.Message, Color.Red);
            }
        }

        public async Task RunTelegramBotAsync()
        {
            var client = CreateTelegramClient();
            if (client.IsConnected)
            {
                if (await client.ConnectAsync())
                {
                    if (await AuthenticateUser(client))
                    {
                        if(await GetCurrencies())
                            await GetMessages(client);
                    }
                }
            }
        }

        public TelegramClient CreateTelegramClient()
        {
            var apiId = Settings.Default.TelegramApiId;
            var apiHash = Settings.Default.TelegramApiHash;
            string fullPathToDat = Directory.GetCurrentDirectory() + "\\session.dat";
            var client = new TelegramClient(apiId, apiHash);
            if (client.IsConnected)
                AddLog("Pavyko prisijungti", "", Color.Green);
            else
                AddLog("Nepavyko prisijungti", "", Color.Red);
            return client;
        }

        public async Task<bool> AuthenticateUser(TelegramClient client)
        {
            try
            {
                var phoneNumber = Settings.Default.TelegramPhoneNumber;
                var hash = await client.SendCodeRequestAsync(phoneNumber);
                var code = GetCode();
                var user = await client.MakeAuthAsync(phoneNumber, hash, code);
                AddLog("Pavyko autentifikuoti: ", "", Color.Green);
                return true;
            }
            catch (Exception ex)
            {
                AddLog("Nepavyko autentifikuoti: ", ex.Message, Color.Red);
                return false;
            }
        }

        public string GetCode()
        {
            var form2 = new Form2();
            var code = "";
            DialogResult dr = form2.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                form2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                code = form2.GetCode();
                form2.Close();
            }
            return code;
        }


        public async Task<bool> GetCurrencies()
        {
            using (var client = new BittrexClient())
            {
                Currencies = await client.GetCurrenciesAsync();
                if (Currencies.Success)
                    AddLog("Pavyko gauti valiutų sąrašą", "", Color.Green);
                else
                    AddLog("Nepavyko gauti valiutų sąrašo", Currencies.Error.ErrorMessage, Color.Red);
                return Currencies.Success ? true : false;
            }
        }

        public async Task GetMessages(TelegramClient client)
        {
            StartBot.Enabled = false;
            StartBot.Text = "Vykdoma...";
            runTelegramBot = true;
            var state = await client.SendRequestAsync<TLState>(new TLRequestGetState());
            var req = new TLRequestGetDifference() { Date = state.Date, Pts = state.Pts, Qts = state.Qts };
            var diff = await client.SendRequestAsync<TLAbsDifference>(req) as TLDifference;
            AddLog("Laukiama telegram signalų", "", Color.Green);

            while (runTelegramBot)
            {
                state = await client.SendRequestAsync<TLState>(new TLRequestGetState());
                StartBot.BackColor = Color.Red;
                await Task.Delay(700);
                if (diff != null)
                {
                    foreach (var upd in diff.NewMessages.ToList().OfType<TLMessage>())
                    {
                        SetDataFromMessage(upd.Message.ToString());
                    }
                }
                StartBot.BackColor = Color.Green;
                await Task.Delay(5000);
                req = new TLRequestGetDifference() { Date = state.Date, Pts = state.Pts, Qts = state.Qts };
                diff = await client.SendRequestAsync<TLAbsDifference>(req) as TLDifference;
            }
            StartBot.Enabled = true;
            StartBot.Text = "Pradėti";
            StartBot.BackColor = SystemColors.Control;
        }

        public void SetDataFromMessage(string messageString)
        {
                var message = messageString;
                var newMessage = message;
                string[] symbols = new string[] { "(", "\u2757", ")", "Buy price", "Sell price", "-", "\n", "\r" };
                foreach (var ch in symbols)
                    newMessage = newMessage.Replace(ch, " ");
                var currency = GetCurrencyFromMessage(newMessage);
                if ( IfCurrencyExist(currency))
                {
                    var prices =  GetPricesFromMessage(newMessage);
                    if (prices.Count() == 2)
                    {
                        TelegramMessagesGrid.Rows.Add(TelegramMessagesGrid.Rows.Count + 1, currency, prices.ElementAt(0), prices.ElementAt(1), DateTime.Now);
                    AddLog("Pridėtas signalas į sąrašą ID:", (TelegramMessagesGrid.Rows.Count).ToString() + " " + DateTime.Now, Color.Green);
                    }
                    else
                    AddLog("Nepridėtas siganalas iš telegram:", message + " " +DateTime.Now, Color.Red);
                }
                else
                AddLog("Nepridėtas siganalas iš telegram:", message + " " + DateTime.Now, Color.Red);
        }

        public bool IfCurrencyExist(string currency)
        {
            var count = Currencies.Result.Count(s => s.Currency == currency);
            if(count == 1)
                AddLog("Valiutų sąraše rasta valiuta: ", currency, Color.Green);
            else
                AddLog("Valiutų sąraše nerasta valiuta: ", currency, Color.Red);
            return count == 0 ? false: true;
        }

        private string GetCurrencyFromMessage(string str)
        {
            try
            {
                var upper = str.Split(' ')
                            .First(s => String.Equals(s, s.ToUpper(),
                                        StringComparison.Ordinal) && s != "" && s != " ");
                return upper;
            }
            catch (Exception ex) {
                AddLog("Signale nerasta valiuta: ", ex.Message, Color.Red);
                return string.Empty;
            } 
        }

        private IEnumerable<string> GetPricesFromMessage(string str)
        {
            try
            {
                var prices = str.Split(' ')
                            .Where(s => decimal.TryParse(s, out var n)).Take(2);
                return prices;
            }
            catch (Exception ex)
            {
                AddLog("Signale nerastos pirkimo kainos: ", ex.Message, Color.Red);
                return null;
            }
        }

        private async void StartBuy_Click(object sender, EventArgs e)
        {
            try
            {
                await RunBittrexBotAsync();
            }
            catch (Exception ex)
            {
                StartBuy.Enabled = true;
                StartBuy.Text = "Prikti";
                StartBuy.BackColor = SystemColors.Control;
                AddLog("Klaida perkant valiutą:  ", ex.Message, Color.Red);
            }
        }

        public async Task RunBittrexBotAsync()
        {
            await AutentificateBittrex();
        }

        public async Task AutentificateBittrex()
        {
            var bittrexApiKey = Settings.Default.BittrexApiKey;
            var bittrexApiSecret = Settings.Default.BittrexApiSecret;
            var client = new BittrexClient(bittrexApiKey, bittrexApiSecret);
            client.MaxRetries = 5;
            using (client)
            {
                client.SetApiCredentials(bittrexApiKey, bittrexApiSecret);

                runBittrexBot = true;
                StartBuy.Enabled = false;
                StartBuy.Text = "Perkama...";
                await Task.Run(() =>
                {
                    while (runBittrexBot)
                    {
                        StartBuy.BackColor = Color.Green;
                        foreach (DataGridViewRow signalRow in TelegramMessagesGrid.Rows)
                        {
                            if (signalRow.Cells[5].Value == null)
                            {
                                var signal = SetSignal(signalRow);

                                decimal lastPrice = 0;

                                var price = client.GetTicker("BTC-" + signal.Currency);
                                lastPrice = price.Result.Last;
                                if (price.Success)
                                    AddLog("Pavyko gauti valiutos kainą: ", "BTC-" + signal.Currency + " " + lastPrice, Color.Green);
                                else
                                    AddLog("Nepavyko gauti valiutos kainos: ", price.Error.ErrorMessage, Color.Red);


                                if (lastPrice >= signal.BuyPriceFrom && lastPrice <= signal.BuyPriceTo)
                                {
                                    decimal? fivePercents = 0;
                                    var balance = client.GetBalance("BTC");
                                    fivePercents = balance.Result.Available.Value;
                                    if (balance.Success)
                                        AddLog("Pavyko gauti valiutos kieki keitykloje: ", "BTC" + balance.Result.Available.Value, Color.Green);
                                    else
                                        AddLog("Nepavyko valiutos kiekio keitykloje: ", balance.Error.ErrorMessage, Color.Red);

                                    var quantity = ((fivePercents / 100) * 5)/lastPrice;

                                    if (quantity != 0)
                                    {
                                        var placedOrder = client.PlaceOrder(OrderType.Buy, "BTC-" + signal.Currency, 30, lastPrice);
                                        if (placedOrder.Success)
                                        {
                                            SetSignalSuccess(signal.Id);
                                            BittrexLogGrid.Rows.Add(signal.Id, signal.Currency, lastPrice, Convert.ToDecimal(quantity), DateTime.Now);
                                            AddLog("Pavyko nusiusti užsakymą: ", "BTC-" + signal.Currency + " " + placedOrder.Result.Uuid, Color.Green);
                                        }
                                        else
                                            AddLog("Nepavyko nusiusti užsakymo:  ", placedOrder.Error.ErrorMessage, Color.Red);
                                    }
                                }
                            }
                        }
                        Thread.Sleep(3000);
                        //await Task.Delay(3000);
                        StartBuy.BackColor = Color.Red;
                        Thread.Sleep(700);
                        //await Task.Delay(200);
                    }
                });
                StartBuy.Enabled = true;
                StartBuy.Text = "Prikti";
                StartBuy.BackColor = SystemColors.Control;
            }
        }


        public TelegramSignal SetSignal(DataGridViewRow telegramSignal)
        {
            var signal = new TelegramSignal
            {
                Currency = telegramSignal.Cells["currency"].Value.ToString(),
                BuyPriceFrom = Convert.ToDecimal(telegramSignal.Cells["buyPriceFrom"].Value),
                BuyPriceTo = Convert.ToDecimal(telegramSignal.Cells["buyPriceTo"].Value),
                GetTime = Convert.ToDateTime(telegramSignal.Cells["time"].Value)
            };
            return signal;
        }

        public void SetSignalSuccess(int signalId)
        {
            foreach (DataGridViewRow dc in TelegramMessagesGrid.Rows)
            {
                if (dc.Cells[0].Value.ToString()== signalId.ToString())
                {
                    dc.Cells[5].Value = "TAIP";
                }

            }
        }

        private void StopBuy_Click(object sender, EventArgs e)
        {
            StartBuy.Enabled = true;
            runBittrexBot = false;
        }

        private void StopBot_Click(object sender, EventArgs e)
        {
            runTelegramBot = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            LogTextBox.Text = string.Empty;
        }

        private void prisijungimoNustatymaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggroupBox.Visible = TelegramgroupBox.Visible = BittrexgroupBox.Visible = false;
            SettingsgroupBox.Visible = true;
        }

        private void valdymasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggroupBox.Visible = TelegramgroupBox.Visible = BittrexgroupBox.Visible = true;
            SettingsgroupBox.Visible = false;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.BittrexApiSecret = BittrexSecrettextBox.Text;
                Settings.Default.BittrexApiKey = BittrexKeytextBox.Text;
                Settings.Default.TelegramApiHash = telegramHashtextBox.Text;
                Settings.Default.TelegramApiId = Int32.Parse(telegramKeytextBox.Text);
                Settings.Default.TelegramPhoneNumber = telegramPhonetextBox.Text;
                Settings.Default.Save();
                LoggroupBox.Visible = TelegramgroupBox.Visible = BittrexgroupBox.Visible = true;
                SettingsgroupBox.Visible = false;
            }
            catch (Exception ex)
            {
                AddLog("Nepavyko pridėti nustatymų: ", ex.Message, Color.Red);
            }
        }

        public void AddLog(string text, string errorMessage, Color color)
        {
            int length = 0;
            LogTextBox.Invoke(new Action(() => length = LogTextBox.TextLength));
            //int length = LogTextBox.TextLength;
            string logMessage = text + errorMessage;
            LogTextBox.Invoke(new Action(() => LogTextBox.AppendText(text)));
            LogTextBox.Invoke(new Action(() => LogTextBox.SelectionStart = length));
            LogTextBox.Invoke(new Action(() => LogTextBox.SelectionLength = text.Length));
            LogTextBox.Invoke(new Action(() => LogTextBox.SelectionColor = color));

            LogTextBox.Invoke(new Action(() => length = LogTextBox.TextLength));
            LogTextBox.Invoke(new Action(() => LogTextBox.AppendText(errorMessage + "\n")));
            LogTextBox.Invoke(new Action(() => LogTextBox.SelectionStart = length));
            LogTextBox.Invoke(new Action(() => LogTextBox.SelectionLength = errorMessage.Length));
            LogTextBox.Invoke(new Action(() => LogTextBox.SelectionColor = Color.Black));
        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {
            LogTextBox.SelectionStart = LogTextBox.Text.Length;
            LogTextBox.ScrollToCaret();
        }
    }
}
