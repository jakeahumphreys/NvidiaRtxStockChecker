using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using _3080ReleaseTool.Models;
using Microsoft.Win32.SafeHandles;

//NSOMNIC

namespace _3080ReleaseTool
{
    public partial class Main : Form
    {
        Library library = new Library();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProductQty();
        }

        private void UpdateProductQty()
        {
            InventoryTool inventoryTool = new InventoryTool();

            RegionQuantities quantities = inventoryTool.GetStockLevels();

            int ukQty = quantities.UK;
            int usQty = quantities.US;

            txtQtyUk.Text = ukQty.ToString();
            txtQtyUs.Text = usQty.ToString();

            lbLogs.Items.Add("[" + library.getCurrentTime() + "] " + "UK Stock: " + ukQty + " " + "US Stock: " + usQty + ".");
        }

        private void btnManualUpdate_Click(object sender, EventArgs e)
        {
            UpdateProductQty();
        }

        private void tmrAutoRefresh_Tick(object sender, EventArgs e)
        {
            if(cbAutoRefresh.Checked)
            {
                UpdateProductQty();
                checkAlerts();
            }
        }

        private void cbAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAutoRefresh.Checked)
            {
                tmrAutoRefresh.Start();
                cbAlertUk.Enabled = true;
                cbAlertUs.Enabled = true;
                lbLogs.Items.Add("Auto Refresh Started");
            }
            else
            {
                cbAlertUk.Enabled = false;
                cbAlertUs.Enabled = false;
                tmrAutoRefresh.Stop();
                lbLogs.Items.Add("Auto Refresh Stopped");
            }
        }

        private void CheckForCartButton()
        {
            var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Alarm01.wav");
            CartAlert cartAlert = new CartAlert();

            if (cartAlert.checkForCartButton("UK"))
            {
                tmrCartAlert.Stop();
                cbCartChecker.Checked = false;
                lbCartLog.Items.Add("[" + library.getCurrentTime() + "] " + "Cart Button Found!");
                soundPlayer.Play();
            }
            else
            {
                //Out of Stock or Error
                lbCartLog.Items.Add("[" + library.getCurrentTime() + "] " + "UK Out of Stock.");
            }
        }

        private void cbCartChecker_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCartChecker.Checked)
            {
                tmrCartAlert.Start();
                lbCartLog.Items.Add("Started checking for cart button.");
                CheckForCartButton();
            }
            else
            {
                tmrCartAlert.Stop();
                lbCartLog.Items.Add("Stopped checking for cart button.");
            }
        }

        private void tmrCartAlert_Tick(object sender, EventArgs e)
        {
            //add region parameters 
            CheckForCartButton();
        }

        private void cbAlertUk_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAlertUk.Checked)
            {
                numUkAlert.Enabled = true;
            }
            else
            {
                numUkAlert.Enabled = false;
                numUkAlert.Value = 0;
            }
        }

        private void cbAlertUs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlertUs.Checked)
            {
                numUsAlert.Enabled = true;
            }
            else
            {
                numUsAlert.Enabled = false;
                numUsAlert.Value = 0;
            }
        }

        private void checkAlerts()
        {
            var soundPlayer = new SoundPlayer(@"c:\Windows\Media\notify.wav");

            if (cbAlertUk.Checked)
            {
                if(Convert.ToInt32(txtQtyUk.Text) >= numUkAlert.Value)
                {
                    cbAlertUk.Checked = false;
                    soundPlayer.Play();
                }
            }

            if (cbAlertUs.Checked)
            {
                if (Convert.ToInt32(txtQtyUs.Text) >= numUsAlert.Value)
                {
                    cbAlertUs.Checked = false;
                    soundPlayer.Play();
                }
            }
        }

        private void saveLogContents()
        {
            if(lbLogs.Items.Count > 0)
            {
                saveFile.ShowDialog();

                if(saveFile.FileName != "")
                {
                    string path = Path.GetFullPath(saveFile.FileName);
                    TextWriter writer = new StreamWriter(path);
                    foreach (var listBoxItem in lbLogs.Items)
                    {
                        writer.WriteLine(listBoxItem.ToString());
                    }
                    writer.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to save an empty log!");
            }
        }

        private void lblSaveLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saveLogContents();
        }
    }
}
