using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace ClearPaste
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private static string previousPaste;

        public Form1(bool startMinimized)
        {
            InitializeComponent();
            // fetch user settings
            timeoutInput.Value = Properties.Settings.Default.timeout;
            autoStartCheckbox.Checked = Properties.Settings.Default.autostart;

            // set timer
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            setTimer();

            Debug.WriteLine("startMinimized: " + startMinimized);
            if (startMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (Clipboard.ContainsText())
            {
                Debug.WriteLine("Current clipboard data: " + Clipboard.GetData(DataFormats.Text));
                string currentPaste = (string)Clipboard.GetData(DataFormats.Text);
                if (currentPaste != null && currentPaste.Equals(previousPaste))
                {
                    Clipboard.Clear();
                    Debug.WriteLine("Cleared clipboard of current text data");
                }
                previousPaste = currentPaste;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Close();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void setTimer()
        {
            myTimer.Stop();
            myTimer.Interval = Convert.ToInt32(timeoutInput.Value) * 60 * 1000;
            Debug.WriteLine("Timer interval: " + myTimer.Interval);
            myTimer.Start();
        }

        private void timeoutInput_ValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("timeout value changed");
            setTimer();
            Properties.Settings.Default.timeout = timeoutInput.Value;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Paste will be cleared every " + timeoutInput.Value + " minutes";
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void autoStartCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoStartCheckbox.Checked)
            {
                using (RegistryKey runKey = autoRunkey())
                {
                    runKey.SetValue(Application.ProductName, "\"" + Application.ExecutablePath + "\" StartMinimized");
                }
            } 
            else 
            {
                using (RegistryKey runKey = autoRunkey())
                {
                    runKey.DeleteValue(Application.ProductName, false);
                }
            }

            Properties.Settings.Default.autostart = autoStartCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private RegistryKey autoRunkey()
        {
            return Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        }

        private void copyLastPasteButton_Click(object sender, EventArgs e)
        {
            if (previousPaste != null)
            {
                Clipboard.SetText(previousPaste);
                previousPaste = null;
                notifyIcon1.BalloonTipText = "Last paste was copied into clipboard";
                notifyIcon1.ShowBalloonTip(5000);
            }
        }
    }
}
