using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacardi_C
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;


        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);


        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void LeftCPSBar_Scroll(object sender, ScrollEventArgs e)
        {
            LeftCPSValue.Text = LeftCPSBar.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LeftClickButton_Click(object sender, EventArgs e)
        {
            if(LeftClickButton.Text.Contains("ON"))
            {
                LeftClickButton.FillColor = Color.DarkRed;
                LeftClickButton.ForeColor = Color.FromArgb(76,76,76);
                LeftClickButton.Text = "OFF";
            }
            else if (LeftClickButton.Text.Contains("OFF"))
            {
                LeftClickButton.FillColor = Color.FromArgb(76,76,76);
                LeftClickButton.ForeColor = Color.DarkRed;
                LeftClickButton.Text = "ON";
            }

        }

        private void LeftClickButton_TextChanged(object sender, EventArgs e)
        {
            if (LeftClickButton.Text.Contains("OFF"))
            {
                AutoClicker.Start();
            }    
            else
            {
                AutoClicker.Stop();
            }
        }

        int min;
        int max;
        IntPtr hWnd;
        IntPtr hWnd2;
        string currentwin;
        string currentwin2;

        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach(Process clsProcess in processes)
                {
                    if(activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch
            {

            }
            return null;
        }

        private void Randomizer_Tick(object sender, EventArgs e)
        {
            if(LeftClickButton.Text.Contains("OFF"))
            {
                min = LeftCPSBar.Value - 8;
                max = LeftCPSBar.Value + 8;
                Random rand = new Random();
                randomBar.Value = (rand.Next(min, max));

            }
        }
        private async void AutoClicker_Tick(object sender, EventArgs e)
        {
            try
            {
                AutoClicker.Interval = 1000 / randomBar.Value;
            }

            catch
            {

            }

            if (LeftClickButton.Text.Contains("OFF"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();

                if(currentwindow == null)
                {
                    return;
                }

                if(currentwindow.Contains("javaw"))
                {
                    if(MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0202, 0, 0);
                    }
                }
            }
        }

        private async void AutoClicker2_Tick(object sender, EventArgs e)
        {
            try
            {
                AutoClicker2.Interval = 1000 / randomBar.Value;
            }

            catch
            {

            }
            if (RightClickButton.Text.Contains("OFF"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd2 = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();

                if (currentwindow == null)
                {
                    return;
                }

                if (currentwindow.Contains("javaw"))
                {
                    if (MouseButtons == MouseButtons.Right)
                    {
                        PostMessage(hWnd2, 0x0204, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd2, 0x0205, 0, 0);
                    }
                }
            }
        }


        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void siticoneHtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y = offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void RightClickButton_Click(object sender, EventArgs e)
        {
            if (RightClickButton.Text.Contains("ON"))
            {
                RightClickButton.FillColor = Color.DarkRed;
                RightClickButton.ForeColor = Color.FromArgb(76, 76, 76);
                RightClickButton.Text = "OFF";
            }
            else if (RightClickButton.Text.Contains("OFF"))
            {
                RightClickButton.FillColor = Color.FromArgb(76, 76, 76);
                RightClickButton.ForeColor = Color.DarkRed;
                RightClickButton.Text = "ON";
            }

        }

        private void RightCPSBar_Scroll(object sender, ScrollEventArgs e)
        {
            RightCPSValue.Text = RightCPSBar.Value.ToString();
        }

        private void LeftCPSValue_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
