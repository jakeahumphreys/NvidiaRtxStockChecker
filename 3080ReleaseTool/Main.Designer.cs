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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.txtQtyUk = new System.Windows.Forms.TextBox();
            this.txtQtyUs = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.btnManualUpdate.Location = new System.Drawing.Point(11, 213);
            this.btnManualUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManualUpdate.Name = "btnManualUpdate";
            this.btnManualUpdate.Size = new System.Drawing.Size(327, 26);
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
            this.cbAutoRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoRefresh.Name = "cbAutoRefresh";
            this.cbAutoRefresh.Size = new System.Drawing.Size(132, 24);
            this.cbAutoRefresh.TabIndex = 5;
            this.cbAutoRefresh.Text = "Auto Refresh?";
            this.cbAutoRefresh.UseVisualStyleBackColor = true;
            this.cbAutoRefresh.CheckedChanged += new System.EventHandler(this.cbAutoRefresh_CheckedChanged);
            // 
            // tmrAutoRefresh
            // 
            this.tmrAutoRefresh.Interval = 30000;
            this.tmrAutoRefresh.Tick += new System.EventHandler(this.tmrAutoRefresh_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 199);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtQtyUs);
            this.tabPage1.Controls.Add(this.txtQtyUk);
            this.tabPage1.Controls.Add(this.lblUkQty);
            this.tabPage1.Controls.Add(this.cbAutoRefresh);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(325, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbLogs);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(325, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 20;
            this.lbLogs.Location = new System.Drawing.Point(5, 7);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(315, 144);
            this.lbLogs.TabIndex = 0;
            // 
            // txtQtyUk
            // 
            this.txtQtyUk.Enabled = false;
            this.txtQtyUk.Location = new System.Drawing.Point(184, 7);
            this.txtQtyUk.Name = "txtQtyUk";
            this.txtQtyUk.Size = new System.Drawing.Size(136, 26);
            this.txtQtyUk.TabIndex = 6;
            // 
            // txtQtyUs
            // 
            this.txtQtyUs.Enabled = false;
            this.txtQtyUs.Location = new System.Drawing.Point(184, 39);
            this.txtQtyUs.Name = "txtQtyUs";
            this.txtQtyUs.Size = new System.Drawing.Size(136, 26);
            this.txtQtyUs.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Checking this box will automatically check \r\nNvidia stock and update every 30 sec" +
    "onds.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(325, 166);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 245);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnManualUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "3030 Release Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.TextBox txtQtyUs;
        private System.Windows.Forms.TextBox txtQtyUk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
    }
}

