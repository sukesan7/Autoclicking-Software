namespace Bacardi_C
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
            this.components = new System.ComponentModel.Container();
            this.LeftClickTitle = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LeftCPSBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.LeftCPSValue = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LeftCPSName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.LeftClickButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Randomizer = new System.Windows.Forms.Timer(this.components);
            this.randomBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.TitleName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.BacardiTitle = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.RightClickTitle = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.RightClickButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.RightCPSBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.RightCPSName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.RightCPSValue = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.AutoClicker2 = new System.Windows.Forms.Timer(this.components);
            this.Randomizer2 = new System.Windows.Forms.Timer(this.components);
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // LeftClickTitle
            // 
            this.LeftClickTitle.BackColor = System.Drawing.Color.Transparent;
            this.LeftClickTitle.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftClickTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.LeftClickTitle.Location = new System.Drawing.Point(12, 85);
            this.LeftClickTitle.Name = "LeftClickTitle";
            this.LeftClickTitle.Size = new System.Drawing.Size(92, 23);
            this.LeftClickTitle.TabIndex = 2;
            this.LeftClickTitle.Text = "Left Click CPS";
            // 
            // LeftCPSBar
            // 
            this.LeftCPSBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.LeftCPSBar.Location = new System.Drawing.Point(12, 105);
            this.LeftCPSBar.Maximum = 20;
            this.LeftCPSBar.Minimum = 5;
            this.LeftCPSBar.Name = "LeftCPSBar";
            this.LeftCPSBar.Size = new System.Drawing.Size(361, 42);
            this.LeftCPSBar.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.LeftCPSBar.TabIndex = 3;
            this.LeftCPSBar.ThumbColor = System.Drawing.Color.DarkRed;
            this.LeftCPSBar.Value = 8;
            this.LeftCPSBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LeftCPSBar_Scroll);
            // 
            // LeftCPSValue
            // 
            this.LeftCPSValue.BackColor = System.Drawing.Color.Transparent;
            this.LeftCPSValue.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCPSValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.LeftCPSValue.Location = new System.Drawing.Point(330, 85);
            this.LeftCPSValue.Name = "LeftCPSValue";
            this.LeftCPSValue.Size = new System.Drawing.Size(11, 23);
            this.LeftCPSValue.TabIndex = 4;
            this.LeftCPSValue.Text = "8";
            this.LeftCPSValue.Click += new System.EventHandler(this.LeftCPSValue_Click);
            // 
            // LeftCPSName
            // 
            this.LeftCPSName.BackColor = System.Drawing.Color.Transparent;
            this.LeftCPSName.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCPSName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.LeftCPSName.Location = new System.Drawing.Point(292, 85);
            this.LeftCPSName.Name = "LeftCPSName";
            this.LeftCPSName.Size = new System.Drawing.Size(32, 23);
            this.LeftCPSName.TabIndex = 5;
            this.LeftCPSName.Text = "CPS:";
            this.LeftCPSName.Click += new System.EventHandler(this.siticoneHtmlLabel5_Click);
            // 
            // AutoClicker
            // 
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Tick);
            // 
            // LeftClickButton
            // 
            this.LeftClickButton.Animated = true;
            this.LeftClickButton.CheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.LeftClickButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeftClickButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeftClickButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeftClickButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeftClickButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.LeftClickButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeftClickButton.ForeColor = System.Drawing.Color.DarkRed;
            this.LeftClickButton.Location = new System.Drawing.Point(118, 85);
            this.LeftClickButton.Name = "LeftClickButton";
            this.LeftClickButton.Size = new System.Drawing.Size(80, 23);
            this.LeftClickButton.TabIndex = 6;
            this.LeftClickButton.Text = "ON";
            this.LeftClickButton.TextChanged += new System.EventHandler(this.LeftClickButton_TextChanged);
            this.LeftClickButton.Click += new System.EventHandler(this.LeftClickButton_Click);
            // 
            // Randomizer
            // 
            this.Randomizer.Enabled = true;
            this.Randomizer.Interval = 150;
            this.Randomizer.Tick += new System.EventHandler(this.Randomizer_Tick);
            // 
            // randomBar
            // 
            this.randomBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.randomBar.Location = new System.Drawing.Point(12, 198);
            this.randomBar.Maximum = 30;
            this.randomBar.Name = "randomBar";
            this.randomBar.Size = new System.Drawing.Size(102, 24);
            this.randomBar.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.randomBar.TabIndex = 7;
            this.randomBar.ThumbColor = System.Drawing.Color.DarkRed;
            this.randomBar.Value = 8;
            this.randomBar.Visible = false;
            this.randomBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(5, 29);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(30, 23);
            this.siticoneHtmlLabel1.TabIndex = 8;
            this.siticoneHtmlLabel1.Text = "V0.1";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click_1);
            // 
            // TitleName
            // 
            this.TitleName.BackColor = System.Drawing.Color.Transparent;
            this.TitleName.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.TitleName.Location = new System.Drawing.Point(3, 3);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(152, 31);
            this.TitleName.TabIndex = 0;
            this.TitleName.Text = "Bacardi Clicker";
            this.TitleName.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // BacardiTitle
            // 
            this.BacardiTitle.BackColor = System.Drawing.Color.Transparent;
            this.BacardiTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacardiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BacardiTitle.Location = new System.Drawing.Point(5, 2);
            this.BacardiTitle.Name = "BacardiTitle";
            this.BacardiTitle.Size = new System.Drawing.Size(152, 31);
            this.BacardiTitle.TabIndex = 9;
            this.BacardiTitle.Text = "Bacardi Clicker";
            // 
            // RightClickTitle
            // 
            this.RightClickTitle.BackColor = System.Drawing.Color.Transparent;
            this.RightClickTitle.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightClickTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.RightClickTitle.Location = new System.Drawing.Point(5, 139);
            this.RightClickTitle.Name = "RightClickTitle";
            this.RightClickTitle.Size = new System.Drawing.Size(100, 23);
            this.RightClickTitle.TabIndex = 10;
            this.RightClickTitle.Text = "Right Click CPS";
            this.RightClickTitle.Visible = false;
            // 
            // RightClickButton
            // 
            this.RightClickButton.Animated = true;
            this.RightClickButton.CheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.RightClickButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RightClickButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RightClickButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RightClickButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RightClickButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.RightClickButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RightClickButton.ForeColor = System.Drawing.Color.DarkRed;
            this.RightClickButton.Location = new System.Drawing.Point(118, 139);
            this.RightClickButton.Name = "RightClickButton";
            this.RightClickButton.Size = new System.Drawing.Size(65, 24);
            this.RightClickButton.TabIndex = 11;
            this.RightClickButton.Text = "ON";
            this.RightClickButton.Visible = false;
            this.RightClickButton.Click += new System.EventHandler(this.RightClickButton_Click);
            // 
            // RightCPSBar
            // 
            this.RightCPSBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.RightCPSBar.Location = new System.Drawing.Point(12, 168);
            this.RightCPSBar.Maximum = 20;
            this.RightCPSBar.Minimum = 5;
            this.RightCPSBar.Name = "RightCPSBar";
            this.RightCPSBar.Size = new System.Drawing.Size(102, 24);
            this.RightCPSBar.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.RightCPSBar.TabIndex = 12;
            this.RightCPSBar.ThumbColor = System.Drawing.Color.DarkRed;
            this.RightCPSBar.Value = 8;
            this.RightCPSBar.Visible = false;
            this.RightCPSBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RightCPSBar_Scroll);
            // 
            // RightCPSName
            // 
            this.RightCPSName.BackColor = System.Drawing.Color.Transparent;
            this.RightCPSName.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCPSName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.RightCPSName.Location = new System.Drawing.Point(125, 168);
            this.RightCPSName.Name = "RightCPSName";
            this.RightCPSName.Size = new System.Drawing.Size(32, 23);
            this.RightCPSName.TabIndex = 13;
            this.RightCPSName.Text = "CPS:";
            this.RightCPSName.Visible = false;
            // 
            // RightCPSValue
            // 
            this.RightCPSValue.BackColor = System.Drawing.Color.Transparent;
            this.RightCPSValue.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCPSValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.RightCPSValue.Location = new System.Drawing.Point(163, 169);
            this.RightCPSValue.Name = "RightCPSValue";
            this.RightCPSValue.Size = new System.Drawing.Size(11, 23);
            this.RightCPSValue.TabIndex = 14;
            this.RightCPSValue.Text = "8";
            this.RightCPSValue.Visible = false;
            // 
            // AutoClicker2
            // 
            this.AutoClicker2.Tick += new System.EventHandler(this.AutoClicker2_Tick);
            // 
            // Randomizer2
            // 
            this.Randomizer2.Enabled = true;
            this.Randomizer2.Interval = 150;
            this.Randomizer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.Red;
            this.siticoneButton1.Location = new System.Drawing.Point(278, 184);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(95, 24);
            this.siticoneButton1.TabIndex = 15;
            this.siticoneButton1.Text = "Destruct";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(399, 220);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.RightCPSValue);
            this.Controls.Add(this.RightCPSName);
            this.Controls.Add(this.RightCPSBar);
            this.Controls.Add(this.RightClickButton);
            this.Controls.Add(this.RightClickTitle);
            this.Controls.Add(this.BacardiTitle);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.randomBar);
            this.Controls.Add(this.LeftClickButton);
            this.Controls.Add(this.LeftCPSName);
            this.Controls.Add(this.LeftCPSValue);
            this.Controls.Add(this.LeftCPSBar);
            this.Controls.Add(this.LeftClickTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Bacardi Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LeftClickTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar LeftCPSBar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LeftCPSValue;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LeftCPSName;
        private System.Windows.Forms.Timer AutoClicker;
        private Siticone.Desktop.UI.WinForms.SiticoneButton LeftClickButton;
        private System.Windows.Forms.Timer Randomizer;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar randomBar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel TitleName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel BacardiTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel RightClickTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RightClickButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar RightCPSBar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel RightCPSName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel RightCPSValue;
        private System.Windows.Forms.Timer AutoClicker2;
        private System.Windows.Forms.Timer Randomizer2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}

