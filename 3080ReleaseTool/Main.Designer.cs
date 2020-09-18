namespace _3080ReleaseTool
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.lblUkQty = new System.Windows.Forms.Label();
            this.btnManualUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoRefresh = new System.Windows.Forms.CheckBox();
            this.tmrAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSaveLog = new System.Windows.Forms.LinkLabel();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.numUsAlert = new System.Windows.Forms.NumericUpDown();
            this.numUkAlert = new System.Windows.Forms.NumericUpDown();
            this.cbAlertUs = new System.Windows.Forms.CheckBox();
            this.cbAlertUk = new System.Windows.Forms.CheckBox();
            this.txtQtyUs = new System.Windows.Forms.TextBox();
            this.txtQtyUk = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCartChecker = new System.Windows.Forms.CheckBox();
            this.lbCartLog = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrCartAlert = new System.Windows.Forms.Timer(this.components);
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUsAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUkAlert)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUkQty
            // 
            this.lblUkQty.AutoSize = true;
            this.lblUkQty.Location = new System.Drawing.Point(7, 22);
            this.lblUkQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUkQty.Name = "lblUkQty";
            this.lblUkQty.Size = new System.Drawing.Size(126, 20);
            this.lblUkQty.TabIndex = 0;
            this.lblUkQty.Text = "United Kingdom:";
            // 
            // btnManualUpdate
            // 
            this.btnManualUpdate.Location = new System.Drawing.Point(90, 70);
            this.btnManualUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualUpdate.Name = "btnManualUpdate";
            this.btnManualUpdate.Size = new System.Drawing.Size(228, 26);
            this.btnManualUpdate.TabIndex = 2;
            this.btnManualUpdate.Text = "Manual Update";
            this.btnManualUpdate.UseVisualStyleBackColor = true;
            this.btnManualUpdate.Click += new System.EventHandler(this.btnManualUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "United States:";
            // 
            // cbAutoRefresh
            // 
            this.cbAutoRefresh.AutoSize = true;
            this.cbAutoRefresh.Location = new System.Drawing.Point(11, 24);
            this.cbAutoRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoRefresh.Name = "cbAutoRefresh";
            this.cbAutoRefresh.Size = new System.Drawing.Size(132, 24);
            this.cbAutoRefresh.TabIndex = 5;
            this.cbAutoRefresh.Text = "Auto Refresh?";
            this.cbAutoRefresh.UseVisualStyleBackColor = true;
            this.cbAutoRefresh.CheckedChanged += new System.EventHandler(this.cbAutoRefresh_CheckedChanged);
            // 
            // tmrAutoRefresh
            // 
            this.tmrAutoRefresh.Interval = 60000;
            this.tmrAutoRefresh.Tick += new System.EventHandler(this.tmrAutoRefresh_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 443);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(611, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nvidia Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSaveLog
            // 
            this.lblSaveLog.AutoSize = true;
            this.lblSaveLog.Location = new System.Drawing.Point(5, 73);
            this.lblSaveLog.Name = "lblSaveLog";
            this.lblSaveLog.Size = new System.Drawing.Size(80, 20);
            this.lblSaveLog.TabIndex = 14;
            this.lblSaveLog.TabStop = true;
            this.lblSaveLog.Text = "Save Log ";
            this.lblSaveLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSaveLog_LinkClicked);
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 20;
            this.lbLogs.Location = new System.Drawing.Point(9, 25);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(576, 104);
            this.lbLogs.TabIndex = 13;
            // 
            // numUsAlert
            // 
            this.numUsAlert.Enabled = false;
            this.numUsAlert.Location = new System.Drawing.Point(91, 54);
            this.numUsAlert.Name = "numUsAlert";
            this.numUsAlert.Size = new System.Drawing.Size(134, 26);
            this.numUsAlert.TabIndex = 12;
            // 
            // numUkAlert
            // 
            this.numUkAlert.Enabled = false;
            this.numUkAlert.Location = new System.Drawing.Point(91, 23);
            this.numUkAlert.Name = "numUkAlert";
            this.numUkAlert.Size = new System.Drawing.Size(135, 26);
            this.numUkAlert.TabIndex = 11;
            // 
            // cbAlertUs
            // 
            this.cbAlertUs.AutoSize = true;
            this.cbAlertUs.Enabled = false;
            this.cbAlertUs.Location = new System.Drawing.Point(15, 55);
            this.cbAlertUs.Name = "cbAlertUs";
            this.cbAlertUs.Size = new System.Drawing.Size(51, 24);
            this.cbAlertUs.TabIndex = 10;
            this.cbAlertUs.Text = "US";
            this.cbAlertUs.UseVisualStyleBackColor = true;
            this.cbAlertUs.CheckedChanged += new System.EventHandler(this.cbAlertUs_CheckedChanged);
            // 
            // cbAlertUk
            // 
            this.cbAlertUk.AutoSize = true;
            this.cbAlertUk.Enabled = false;
            this.cbAlertUk.Location = new System.Drawing.Point(15, 25);
            this.cbAlertUk.Name = "cbAlertUk";
            this.cbAlertUk.Size = new System.Drawing.Size(50, 24);
            this.cbAlertUk.TabIndex = 9;
            this.cbAlertUk.Text = "UK";
            this.cbAlertUk.UseVisualStyleBackColor = true;
            this.cbAlertUk.CheckedChanged += new System.EventHandler(this.cbAlertUk_CheckedChanged);
            // 
            // txtQtyUs
            // 
            this.txtQtyUs.Enabled = false;
            this.txtQtyUs.Location = new System.Drawing.Point(399, 19);
            this.txtQtyUs.Name = "txtQtyUs";
            this.txtQtyUs.Size = new System.Drawing.Size(189, 26);
            this.txtQtyUs.TabIndex = 7;
            // 
            // txtQtyUk
            // 
            this.txtQtyUk.Enabled = false;
            this.txtQtyUk.Location = new System.Drawing.Point(133, 19);
            this.txtQtyUk.Name = "txtQtyUk";
            this.txtQtyUk.Size = new System.Drawing.Size(149, 26);
            this.txtQtyUk.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(611, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cart Alert";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(590, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cart Alert checks the RTX 3080 Webpage for the \'Add to Cart\' button every 30 \r\nse" +
    "conds. When the button is found an alert will play and the check will stop looki" +
    "ng.\r\n";
            // 
            // cbCartChecker
            // 
            this.cbCartChecker.AutoSize = true;
            this.cbCartChecker.Location = new System.Drawing.Point(268, 42);
            this.cbCartChecker.Name = "cbCartChecker";
            this.cbCartChecker.Size = new System.Drawing.Size(184, 24);
            this.cbCartChecker.TabIndex = 1;
            this.cbCartChecker.Text = "Check for \'Add to cart\'";
            this.cbCartChecker.UseVisualStyleBackColor = true;
            this.cbCartChecker.CheckedChanged += new System.EventHandler(this.cbCartChecker_CheckedChanged);
            // 
            // lbCartLog
            // 
            this.lbCartLog.FormattingEnabled = true;
            this.lbCartLog.ItemHeight = 20;
            this.lbCartLog.Location = new System.Drawing.Point(10, 25);
            this.lbCartLog.Name = "lbCartLog";
            this.lbCartLog.Size = new System.Drawing.Size(580, 144);
            this.lbCartLog.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(611, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Created by Nsomnic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "A Simplistic tool to query Nvidia RTX 3080 Stock Levels by sending a \r\nrequest to" +
    " the appropriate endpoint URLS\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCartAlert
            // 
            this.tmrCartAlert.Interval = 20000;
            this.tmrCartAlert.Tick += new System.EventHandler(this.tmrCartAlert_Tick);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.Title = "Save Log";
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "UK"});
            this.cbRegion.Location = new System.Drawing.Point(15, 40);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(238, 28);
            this.cbRegion.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRegion);
            this.groupBox1.Controls.Add(this.cbCartChecker);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCartLog);
            this.groupBox3.Location = new System.Drawing.Point(6, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 186);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cart Alert Logs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblUkQty);
            this.groupBox4.Controls.Add(this.txtQtyUk);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtQtyUs);
            this.groupBox4.Location = new System.Drawing.Point(11, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 64);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock Levels";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnManualUpdate);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblSaveLog);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.cbAutoRefresh);
            this.groupBox5.Location = new System.Drawing.Point(11, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(591, 105);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuration";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbAlertUk);
            this.groupBox6.Controls.Add(this.numUkAlert);
            this.groupBox6.Controls.Add(this.cbAlertUs);
            this.groupBox6.Controls.Add(this.numUsAlert);
            this.groupBox6.Location = new System.Drawing.Point(347, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 87);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alerting";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(11, 187);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(591, 80);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "About";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbLogs);
            this.groupBox8.Location = new System.Drawing.Point(11, 273);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(591, 132);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Inventory Logs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "(Every 60 Seconds)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Auto-Refresh must be toggled for alerting to unlock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(579, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "This tool automatically retrieves inventory data from Nvidia\'s Digitalriver endpo" +
    "ints.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(568, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "v1.2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 464);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "3030 Release Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUsAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUkAlert)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUkQty;
        private System.Windows.Forms.Button btnManualUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAutoRefresh;
        private System.Windows.Forms.Timer tmrAutoRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtQtyUs;
        private System.Windows.Forms.TextBox txtQtyUk;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAlertUs;
        private System.Windows.Forms.CheckBox cbAlertUk;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbCartChecker;
        private System.Windows.Forms.ListBox lbCartLog;
        private System.Windows.Forms.Timer tmrCartAlert;
        private System.Windows.Forms.NumericUpDown numUsAlert;
        private System.Windows.Forms.NumericUpDown numUkAlert;
        private System.Windows.Forms.LinkLabel lblSaveLog;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}

