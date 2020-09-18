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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblUkQty = new System.Windows.Forms.Label();
            this.btnManualUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoRefresh = new System.Windows.Forms.CheckBox();
            this.tmrAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtyUs = new System.Windows.Forms.TextBox();
            this.txtQtyUk = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAlertUk = new System.Windows.Forms.CheckBox();
            this.cbAlertUs = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbCartLog = new System.Windows.Forms.ListBox();
            this.cbCartChecker = new System.Windows.Forms.CheckBox();
            this.tmrCartAlert = new System.Windows.Forms.Timer(this.components);
            this.numUkAlert = new System.Windows.Forms.NumericUpDown();
            this.numUsAlert = new System.Windows.Forms.NumericUpDown();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.lblSaveLog = new System.Windows.Forms.LinkLabel();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUkAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUkQty
            // 
            this.lblUkQty.AutoSize = true;
            this.lblUkQty.Location = new System.Drawing.Point(7, 10);
            this.lblUkQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUkQty.Name = "lblUkQty";
            this.lblUkQty.Size = new System.Drawing.Size(175, 20);
            this.lblUkQty.TabIndex = 0;
            this.lblUkQty.Text = "Available Quantity (UK):";
            // 
            // btnManualUpdate
            // 
            this.btnManualUpdate.Location = new System.Drawing.Point(11, 457);
            this.btnManualUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualUpdate.Name = "btnManualUpdate";
            this.btnManualUpdate.Size = new System.Drawing.Size(612, 26);
            this.btnManualUpdate.TabIndex = 2;
            this.btnManualUpdate.Text = "Manual Update";
            this.btnManualUpdate.UseVisualStyleBackColor = true;
            this.btnManualUpdate.Click += new System.EventHandler(this.btnManualUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Quantity (US):";
            // 
            // cbAutoRefresh
            // 
            this.cbAutoRefresh.AutoSize = true;
            this.cbAutoRefresh.Location = new System.Drawing.Point(11, 77);
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
            this.tmrAutoRefresh.Interval = 5000;
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
            this.tabPage1.Controls.Add(this.lblSaveLog);
            this.tabPage1.Controls.Add(this.lbLogs);
            this.tabPage1.Controls.Add(this.numUsAlert);
            this.tabPage1.Controls.Add(this.numUkAlert);
            this.tabPage1.Controls.Add(this.cbAlertUs);
            this.tabPage1.Controls.Add(this.cbAlertUk);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtQtyUs);
            this.tabPage1.Controls.Add(this.txtQtyUk);
            this.tabPage1.Controls.Add(this.lblUkQty);
            this.tabPage1.Controls.Add(this.cbAutoRefresh);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(611, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nvidia Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 60);
            this.label2.TabIndex = 8;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // txtQtyUs
            // 
            this.txtQtyUs.Enabled = false;
            this.txtQtyUs.Location = new System.Drawing.Point(184, 39);
            this.txtQtyUs.Name = "txtQtyUs";
            this.txtQtyUs.Size = new System.Drawing.Size(189, 26);
            this.txtQtyUs.TabIndex = 7;
            // 
            // txtQtyUk
            // 
            this.txtQtyUk.Enabled = false;
            this.txtQtyUk.Location = new System.Drawing.Point(184, 7);
            this.txtQtyUk.Name = "txtQtyUk";
            this.txtQtyUk.Size = new System.Drawing.Size(189, 26);
            this.txtQtyUk.TabIndex = 6;
            // 
            // tabPage3
            // 
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
            this.label4.Location = new System.Drawing.Point(88, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Created by Nsomnic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "A Simplistic tool to query Nvidia RTX 3080 Stock\r\nLevels by sending a request to " +
    "the appropriate\r\nendpoint URLS\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAlertUk
            // 
            this.cbAlertUk.AutoSize = true;
            this.cbAlertUk.Enabled = false;
            this.cbAlertUk.Location = new System.Drawing.Point(391, 11);
            this.cbAlertUk.Name = "cbAlertUk";
            this.cbAlertUk.Size = new System.Drawing.Size(70, 24);
            this.cbAlertUk.TabIndex = 9;
            this.cbAlertUk.Text = "Alert?";
            this.cbAlertUk.UseVisualStyleBackColor = true;
            this.cbAlertUk.CheckedChanged += new System.EventHandler(this.cbAlertUk_CheckedChanged);
            // 
            // cbAlertUs
            // 
            this.cbAlertUs.AutoSize = true;
            this.cbAlertUs.Enabled = false;
            this.cbAlertUs.Location = new System.Drawing.Point(391, 37);
            this.cbAlertUs.Name = "cbAlertUs";
            this.cbAlertUs.Size = new System.Drawing.Size(70, 24);
            this.cbAlertUs.TabIndex = 10;
            this.cbAlertUs.Text = "Alert?";
            this.cbAlertUs.UseVisualStyleBackColor = true;
            this.cbAlertUs.CheckedChanged += new System.EventHandler(this.cbAlertUs_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.cbCartChecker);
            this.tabPage4.Controls.Add(this.lbCartLog);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(611, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cart Alert";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbCartLog
            // 
            this.lbCartLog.FormattingEnabled = true;
            this.lbCartLog.ItemHeight = 20;
            this.lbCartLog.Location = new System.Drawing.Point(6, 130);
            this.lbCartLog.Name = "lbCartLog";
            this.lbCartLog.Size = new System.Drawing.Size(599, 264);
            this.lbCartLog.TabIndex = 0;
            // 
            // cbCartChecker
            // 
            this.cbCartChecker.AutoSize = true;
            this.cbCartChecker.Location = new System.Drawing.Point(9, 13);
            this.cbCartChecker.Name = "cbCartChecker";
            this.cbCartChecker.Size = new System.Drawing.Size(267, 24);
            this.cbCartChecker.TabIndex = 1;
            this.cbCartChecker.Text = "Check for \'Add to cart\' (UK ONLY)";
            this.cbCartChecker.UseVisualStyleBackColor = true;
            this.cbCartChecker.CheckedChanged += new System.EventHandler(this.cbCartChecker_CheckedChanged);
            // 
            // tmrCartAlert
            // 
            this.tmrCartAlert.Interval = 20000;
            this.tmrCartAlert.Tick += new System.EventHandler(this.tmrCartAlert_Tick);
            // 
            // numUkAlert
            // 
            this.numUkAlert.Enabled = false;
            this.numUkAlert.Location = new System.Drawing.Point(467, 8);
            this.numUkAlert.Name = "numUkAlert";
            this.numUkAlert.Size = new System.Drawing.Size(135, 26);
            this.numUkAlert.TabIndex = 11;
            // 
            // numUsAlert
            // 
            this.numUsAlert.Enabled = false;
            this.numUsAlert.Location = new System.Drawing.Point(468, 38);
            this.numUsAlert.Name = "numUsAlert";
            this.numUsAlert.Size = new System.Drawing.Size(134, 26);
            this.numUsAlert.TabIndex = 12;
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 20;
            this.lbLogs.Location = new System.Drawing.Point(7, 173);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(595, 204);
            this.lbLogs.TabIndex = 13;
            // 
            // lblSaveLog
            // 
            this.lblSaveLog.AutoSize = true;
            this.lblSaveLog.Location = new System.Drawing.Point(7, 380);
            this.lblSaveLog.Name = "lblSaveLog";
            this.lblSaveLog.Size = new System.Drawing.Size(80, 20);
            this.lblSaveLog.TabIndex = 14;
            this.lblSaveLog.TabStop = true;
            this.lblSaveLog.Text = "Save Log ";
            this.lblSaveLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSaveLog_LinkClicked);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "txt";
            this.saveFile.Title = "Save Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(542, 60);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cart Alert checks the RTX 3080 Webpage for the \'Add to Cart\' button every \r\n30 se" +
    "conds. When the button is found an alert will play and the check will\r\nstop look" +
    "ing.\r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnManualUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "3030 Release Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUkAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsAlert)).EndInit();
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
        private System.Windows.Forms.Label label2;
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
    }
}

