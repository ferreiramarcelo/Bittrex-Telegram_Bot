namespace CoinBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartBot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBuy = new System.Windows.Forms.Button();
            this.TelegramMessagesGrid = new System.Windows.Forms.DataGridView();
            this.BittrexLogGrid = new System.Windows.Forms.DataGridView();
            this.SignalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.TelegramgroupBox = new System.Windows.Forms.GroupBox();
            this.StopBot = new System.Windows.Forms.Button();
            this.BittrexgroupBox = new System.Windows.Forms.GroupBox();
            this.StopBuy = new System.Windows.Forms.Button();
            this.LoggroupBox = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prisijungimoNustatymaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valdymasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.SettingsgroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BittrexSecrettextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BittrexKeytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telegramPhonetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telegramHashtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telegramKeytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Succsess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramMessagesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BittrexLogGrid)).BeginInit();
            this.TelegramgroupBox.SuspendLayout();
            this.BittrexgroupBox.SuspendLayout();
            this.LoggroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SettingsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBot
            // 
            this.StartBot.Location = new System.Drawing.Point(661, 19);
            this.StartBot.Name = "StartBot";
            this.StartBot.Size = new System.Drawing.Size(75, 32);
            this.StartBot.TabIndex = 0;
            this.StartBot.Text = "Pradėti";
            this.StartBot.UseVisualStyleBackColor = true;
            this.StartBot.Click += new System.EventHandler(this.StartBot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // StartBuy
            // 
            this.StartBuy.Location = new System.Drawing.Point(661, 17);
            this.StartBuy.Name = "StartBuy";
            this.StartBuy.Size = new System.Drawing.Size(75, 32);
            this.StartBuy.TabIndex = 2;
            this.StartBuy.Text = "Pirkti";
            this.StartBuy.UseVisualStyleBackColor = true;
            this.StartBuy.Click += new System.EventHandler(this.StartBuy_Click);
            // 
            // TelegramMessagesGrid
            // 
            this.TelegramMessagesGrid.AllowUserToAddRows = false;
            this.TelegramMessagesGrid.AllowUserToDeleteRows = false;
            this.TelegramMessagesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TelegramMessagesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelegramMessagesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.currency,
            this.buyPriceFrom,
            this.buyPriceTo,
            this.time,
            this.Succsess});
            this.TelegramMessagesGrid.Location = new System.Drawing.Point(6, 19);
            this.TelegramMessagesGrid.Name = "TelegramMessagesGrid";
            this.TelegramMessagesGrid.ReadOnly = true;
            this.TelegramMessagesGrid.RowHeadersVisible = false;
            this.TelegramMessagesGrid.Size = new System.Drawing.Size(649, 219);
            this.TelegramMessagesGrid.TabIndex = 3;
            // 
            // BittrexLogGrid
            // 
            this.BittrexLogGrid.AllowUserToAddRows = false;
            this.BittrexLogGrid.AllowUserToDeleteRows = false;
            this.BittrexLogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BittrexLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BittrexLogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SignalId,
            this.currencyName,
            this.price,
            this.quantity,
            this.date});
            this.BittrexLogGrid.Location = new System.Drawing.Point(6, 17);
            this.BittrexLogGrid.Name = "BittrexLogGrid";
            this.BittrexLogGrid.ReadOnly = true;
            this.BittrexLogGrid.RowHeadersVisible = false;
            this.BittrexLogGrid.Size = new System.Drawing.Size(649, 220);
            this.BittrexLogGrid.TabIndex = 4;
            // 
            // SignalId
            // 
            this.SignalId.FillWeight = 50.76142F;
            this.SignalId.HeaderText = "Signalo ID";
            this.SignalId.Name = "SignalId";
            this.SignalId.ReadOnly = true;
            // 
            // currencyName
            // 
            this.currencyName.FillWeight = 112.3096F;
            this.currencyName.HeaderText = "Valiuta";
            this.currencyName.Name = "currencyName";
            this.currencyName.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 112.3096F;
            this.price.HeaderText = "Kaina";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Kiekis";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 112.3096F;
            this.date.HeaderText = "Laikas";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.LogTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogTextBox.Location = new System.Drawing.Point(6, 19);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(649, 189);
            this.LogTextBox.TabIndex = 5;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // TelegramgroupBox
            // 
            this.TelegramgroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.TelegramgroupBox.Controls.Add(this.StopBot);
            this.TelegramgroupBox.Controls.Add(this.label1);
            this.TelegramgroupBox.Controls.Add(this.StartBot);
            this.TelegramgroupBox.Controls.Add(this.TelegramMessagesGrid);
            this.TelegramgroupBox.Location = new System.Drawing.Point(15, 12);
            this.TelegramgroupBox.Name = "TelegramgroupBox";
            this.TelegramgroupBox.Size = new System.Drawing.Size(744, 249);
            this.TelegramgroupBox.TabIndex = 6;
            this.TelegramgroupBox.TabStop = false;
            this.TelegramgroupBox.Text = "Iš telegram gauti signalai";
            // 
            // StopBot
            // 
            this.StopBot.Location = new System.Drawing.Point(661, 57);
            this.StopBot.Name = "StopBot";
            this.StopBot.Size = new System.Drawing.Size(75, 32);
            this.StopBot.TabIndex = 9;
            this.StopBot.Text = "Stabdyti";
            this.StopBot.UseVisualStyleBackColor = true;
            this.StopBot.Click += new System.EventHandler(this.StopBot_Click);
            // 
            // BittrexgroupBox
            // 
            this.BittrexgroupBox.Controls.Add(this.StopBuy);
            this.BittrexgroupBox.Controls.Add(this.StartBuy);
            this.BittrexgroupBox.Controls.Add(this.BittrexLogGrid);
            this.BittrexgroupBox.Location = new System.Drawing.Point(15, 267);
            this.BittrexgroupBox.Name = "BittrexgroupBox";
            this.BittrexgroupBox.Size = new System.Drawing.Size(744, 248);
            this.BittrexgroupBox.TabIndex = 7;
            this.BittrexgroupBox.TabStop = false;
            this.BittrexgroupBox.Text = "Atlikti pirkimai bittrex";
            // 
            // StopBuy
            // 
            this.StopBuy.Location = new System.Drawing.Point(661, 55);
            this.StopBuy.Name = "StopBuy";
            this.StopBuy.Size = new System.Drawing.Size(75, 32);
            this.StopBuy.TabIndex = 5;
            this.StopBuy.Text = "Atšaukti";
            this.StopBuy.UseVisualStyleBackColor = true;
            this.StopBuy.Click += new System.EventHandler(this.StopBuy_Click);
            // 
            // LoggroupBox
            // 
            this.LoggroupBox.Controls.Add(this.Delete);
            this.LoggroupBox.Controls.Add(this.LogTextBox);
            this.LoggroupBox.Location = new System.Drawing.Point(15, 522);
            this.LoggroupBox.Name = "LoggroupBox";
            this.LoggroupBox.Size = new System.Drawing.Size(744, 218);
            this.LoggroupBox.TabIndex = 8;
            this.LoggroupBox.TabStop = false;
            this.LoggroupBox.Text = "Žurnalizavimas";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(661, 19);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 32);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Išvalyti";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prisijungimoNustatymaiToolStripMenuItem,
            this.valdymasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prisijungimoNustatymaiToolStripMenuItem
            // 
            this.prisijungimoNustatymaiToolStripMenuItem.Name = "prisijungimoNustatymaiToolStripMenuItem";
            this.prisijungimoNustatymaiToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.prisijungimoNustatymaiToolStripMenuItem.Text = "Prisijungimo nustatymai";
            this.prisijungimoNustatymaiToolStripMenuItem.Click += new System.EventHandler(this.prisijungimoNustatymaiToolStripMenuItem_Click);
            // 
            // valdymasToolStripMenuItem
            // 
            this.valdymasToolStripMenuItem.Name = "valdymasToolStripMenuItem";
            this.valdymasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.valdymasToolStripMenuItem.Text = "Valdymas";
            this.valdymasToolStripMenuItem.Click += new System.EventHandler(this.valdymasToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SettingsgroupBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TelegramgroupBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LoggroupBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BittrexgroupBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(774, 752);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(774, 776);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // SettingsgroupBox
            // 
            this.SettingsgroupBox.Controls.Add(this.button1);
            this.SettingsgroupBox.Controls.Add(this.BittrexSecrettextBox);
            this.SettingsgroupBox.Controls.Add(this.label6);
            this.SettingsgroupBox.Controls.Add(this.BittrexKeytextBox);
            this.SettingsgroupBox.Controls.Add(this.label5);
            this.SettingsgroupBox.Controls.Add(this.telegramPhonetextBox);
            this.SettingsgroupBox.Controls.Add(this.label4);
            this.SettingsgroupBox.Controls.Add(this.telegramHashtextBox);
            this.SettingsgroupBox.Controls.Add(this.label3);
            this.SettingsgroupBox.Controls.Add(this.telegramKeytextBox);
            this.SettingsgroupBox.Controls.Add(this.label2);
            this.SettingsgroupBox.Location = new System.Drawing.Point(202, 256);
            this.SettingsgroupBox.Name = "SettingsgroupBox";
            this.SettingsgroupBox.Size = new System.Drawing.Size(389, 203);
            this.SettingsgroupBox.TabIndex = 11;
            this.SettingsgroupBox.TabStop = false;
            this.SettingsgroupBox.Text = "Prisijungimo nustatymai";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Išsaugoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // BittrexSecrettextBox
            // 
            this.BittrexSecrettextBox.Location = new System.Drawing.Point(106, 121);
            this.BittrexSecrettextBox.Name = "BittrexSecrettextBox";
            this.BittrexSecrettextBox.Size = new System.Drawing.Size(250, 20);
            this.BittrexSecrettextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bittrex Api Secret:";
            // 
            // BittrexKeytextBox
            // 
            this.BittrexKeytextBox.Location = new System.Drawing.Point(106, 95);
            this.BittrexKeytextBox.Name = "BittrexKeytextBox";
            this.BittrexKeytextBox.Size = new System.Drawing.Size(250, 20);
            this.BittrexKeytextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bittrex Api Key:";
            // 
            // telegramPhonetextBox
            // 
            this.telegramPhonetextBox.Location = new System.Drawing.Point(106, 69);
            this.telegramPhonetextBox.Name = "telegramPhonetextBox";
            this.telegramPhonetextBox.Size = new System.Drawing.Size(250, 20);
            this.telegramPhonetextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telegram tel. Nr.:";
            // 
            // telegramHashtextBox
            // 
            this.telegramHashtextBox.Location = new System.Drawing.Point(106, 43);
            this.telegramHashtextBox.Name = "telegramHashtextBox";
            this.telegramHashtextBox.Size = new System.Drawing.Size(250, 20);
            this.telegramHashtextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telegram Api Hash:";
            // 
            // telegramKeytextBox
            // 
            this.telegramKeytextBox.Location = new System.Drawing.Point(106, 17);
            this.telegramKeytextBox.Name = "telegramKeytextBox";
            this.telegramKeytextBox.Size = new System.Drawing.Size(250, 20);
            this.telegramKeytextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telegram Api Key:";
            // 
            // Id
            // 
            this.Id.FillWeight = 49.18103F;
            this.Id.HeaderText = "Signalo ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // currency
            // 
            this.currency.FillWeight = 108.813F;
            this.currency.HeaderText = "Valiuta";
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            // 
            // buyPriceFrom
            // 
            this.buyPriceFrom.FillWeight = 108.813F;
            this.buyPriceFrom.HeaderText = "Pirkimo kaina nuo";
            this.buyPriceFrom.Name = "buyPriceFrom";
            this.buyPriceFrom.ReadOnly = true;
            // 
            // buyPriceTo
            // 
            this.buyPriceTo.FillWeight = 108.813F;
            this.buyPriceTo.HeaderText = "Pirkimo kaina iki";
            this.buyPriceTo.Name = "buyPriceTo";
            this.buyPriceTo.ReadOnly = true;
            // 
            // time
            // 
            this.time.FillWeight = 108.813F;
            this.time.HeaderText = "Laikas";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // Succsess
            // 
            this.Succsess.HeaderText = "Valiuta nupirkta";
            this.Succsess.Name = "Succsess";
            this.Succsess.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 776);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CoinBot";
            ((System.ComponentModel.ISupportInitialize)(this.TelegramMessagesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BittrexLogGrid)).EndInit();
            this.TelegramgroupBox.ResumeLayout(false);
            this.TelegramgroupBox.PerformLayout();
            this.BittrexgroupBox.ResumeLayout(false);
            this.LoggroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.SettingsgroupBox.ResumeLayout(false);
            this.SettingsgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBuy;
        private System.Windows.Forms.DataGridView TelegramMessagesGrid;
        private System.Windows.Forms.DataGridView BittrexLogGrid;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.GroupBox TelegramgroupBox;
        private System.Windows.Forms.GroupBox BittrexgroupBox;
        private System.Windows.Forms.Button StopBot;
        private System.Windows.Forms.GroupBox LoggroupBox;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button StopBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prisijungimoNustatymaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valdymasToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.GroupBox SettingsgroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BittrexSecrettextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BittrexKeytextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telegramPhonetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telegramHashtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telegramKeytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Succsess;
    }
}

