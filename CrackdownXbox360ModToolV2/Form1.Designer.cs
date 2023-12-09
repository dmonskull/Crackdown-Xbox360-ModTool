namespace CrackdownXbox360ModToolV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            styleManager1 = new MetroSet_UI.Components.StyleManager();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            tabPage1 = new TabPage();
            textBox2 = new TextBox();
            metroSetButton14 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton12 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton10 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton3 = new MetroSet_UI.Controls.MetroSetButton();
            textBox1 = new TextBox();
            metroSetButton11 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton8 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton7 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton6 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton5 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton4 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetButton9 = new MetroSet_UI.Controls.MetroSetButton();
            metroSetTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // styleManager1
            // 
            styleManager1.CustomTheme = "C:\\Users\\OGAFA\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            styleManager1.MetroForm = this;
            styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            styleManager1.ThemeAuthor = "Narwin";
            styleManager1.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(15, 10);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(172, 23);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetLabel1.StyleManager = styleManager1;
            metroSetLabel1.TabIndex = 1;
            metroSetLabel1.Text = "Connection Lost...";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(756, 10);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(38, 23);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetLabel2.StyleManager = styleManager1;
            metroSetLabel2.TabIndex = 2;
            metroSetLabel2.Text = "EXIT";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroDark";
            metroSetLabel2.Click += metroSetLabel2_Click;
            // 
            // metroSetTabControl1
            // 
            metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            metroSetTabControl1.AnimateTime = 200;
            metroSetTabControl1.BackgroundColor = Color.FromArgb(30, 30, 30);
            metroSetTabControl1.Controls.Add(tabPage1);
            metroSetTabControl1.IsDerivedStyle = true;
            metroSetTabControl1.ItemSize = new Size(100, 38);
            metroSetTabControl1.Location = new Point(15, 127);
            metroSetTabControl1.Name = "metroSetTabControl1";
            metroSetTabControl1.SelectedIndex = 0;
            metroSetTabControl1.SelectedTextColor = Color.White;
            metroSetTabControl1.Size = new Size(770, 308);
            metroSetTabControl1.SizeMode = TabSizeMode.Fixed;
            metroSetTabControl1.Speed = 100;
            metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetTabControl1.StyleManager = styleManager1;
            metroSetTabControl1.TabIndex = 3;
            metroSetTabControl1.ThemeAuthor = "Narwin";
            metroSetTabControl1.ThemeName = "MetroDark";
            metroSetTabControl1.UnselectedTextColor = Color.Gray;
            metroSetTabControl1.UseAnimation = false;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(metroSetButton14);
            tabPage1.Controls.Add(metroSetButton12);
            tabPage1.Controls.Add(metroSetButton10);
            tabPage1.Controls.Add(metroSetButton3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(metroSetButton11);
            tabPage1.Controls.Add(metroSetButton8);
            tabPage1.Controls.Add(metroSetButton7);
            tabPage1.Controls.Add(metroSetButton6);
            tabPage1.Controls.Add(metroSetButton5);
            tabPage1.Controls.Add(metroSetButton4);
            tabPage1.Controls.Add(metroSetButton2);
            tabPage1.ForeColor = Color.Transparent;
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(762, 262);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main Mods";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 16;
            textBox2.Text = "fly";
            // 
            // metroSetButton14
            // 
            metroSetButton14.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton14.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton14.DisabledForeColor = Color.Gray;
            metroSetButton14.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton14.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton14.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton14.HoverTextColor = Color.White;
            metroSetButton14.IsDerivedStyle = true;
            metroSetButton14.Location = new Point(512, 73);
            metroSetButton14.Name = "metroSetButton14";
            metroSetButton14.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton14.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton14.NormalTextColor = Color.White;
            metroSetButton14.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton14.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton14.PressTextColor = Color.White;
            metroSetButton14.Size = new Size(247, 31);
            metroSetButton14.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton14.StyleManager = styleManager1;
            metroSetButton14.TabIndex = 15;
            metroSetButton14.Text = "Send Console Command";
            metroSetButton14.ThemeAuthor = "Narwin";
            metroSetButton14.ThemeName = "MetroDark";
            metroSetButton14.Click += metroSetButton14_Click;
            // 
            // metroSetButton12
            // 
            metroSetButton12.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton12.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton12.DisabledForeColor = Color.Gray;
            metroSetButton12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton12.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton12.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton12.HoverTextColor = Color.White;
            metroSetButton12.IsDerivedStyle = true;
            metroSetButton12.Location = new Point(3, 114);
            metroSetButton12.Name = "metroSetButton12";
            metroSetButton12.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton12.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton12.NormalTextColor = Color.White;
            metroSetButton12.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton12.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton12.PressTextColor = Color.White;
            metroSetButton12.Size = new Size(146, 31);
            metroSetButton12.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton12.StyleManager = styleManager1;
            metroSetButton12.TabIndex = 14;
            metroSetButton12.Text = "FPS: OFF";
            metroSetButton12.ThemeAuthor = "Narwin";
            metroSetButton12.ThemeName = "MetroDark";
            metroSetButton12.Click += metroSetButton12_Click_1;
            // 
            // metroSetButton10
            // 
            metroSetButton10.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton10.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton10.DisabledForeColor = Color.Gray;
            metroSetButton10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton10.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton10.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton10.HoverTextColor = Color.White;
            metroSetButton10.IsDerivedStyle = true;
            metroSetButton10.Location = new Point(3, 77);
            metroSetButton10.Name = "metroSetButton10";
            metroSetButton10.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton10.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton10.NormalTextColor = Color.White;
            metroSetButton10.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton10.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton10.PressTextColor = Color.White;
            metroSetButton10.Size = new Size(146, 31);
            metroSetButton10.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton10.StyleManager = styleManager1;
            metroSetButton10.TabIndex = 13;
            metroSetButton10.Text = "Fly: OFF";
            metroSetButton10.ThemeAuthor = "Narwin";
            metroSetButton10.ThemeName = "MetroDark";
            metroSetButton10.Click += metroSetButton10_Click_2;
            // 
            // metroSetButton3
            // 
            metroSetButton3.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton3.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton3.DisabledForeColor = Color.Gray;
            metroSetButton3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton3.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton3.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton3.HoverTextColor = Color.White;
            metroSetButton3.IsDerivedStyle = true;
            metroSetButton3.Location = new Point(3, 3);
            metroSetButton3.Name = "metroSetButton3";
            metroSetButton3.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton3.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton3.NormalTextColor = Color.White;
            metroSetButton3.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton3.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton3.PressTextColor = Color.White;
            metroSetButton3.Size = new Size(146, 31);
            metroSetButton3.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton3.StyleManager = styleManager1;
            metroSetButton3.TabIndex = 12;
            metroSetButton3.Text = "Godmode: OFF";
            metroSetButton3.ThemeAuthor = "Narwin";
            metroSetButton3.ThemeName = "MetroDark";
            metroSetButton3.Click += metroSetButton3_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(512, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "fly";
            // 
            // metroSetButton11
            // 
            metroSetButton11.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton11.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton11.DisabledForeColor = Color.Gray;
            metroSetButton11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton11.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton11.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton11.HoverTextColor = Color.White;
            metroSetButton11.IsDerivedStyle = true;
            metroSetButton11.Location = new Point(512, 3);
            metroSetButton11.Name = "metroSetButton11";
            metroSetButton11.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton11.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton11.NormalTextColor = Color.White;
            metroSetButton11.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton11.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton11.PressTextColor = Color.White;
            metroSetButton11.Size = new Size(247, 31);
            metroSetButton11.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton11.StyleManager = styleManager1;
            metroSetButton11.TabIndex = 10;
            metroSetButton11.Text = "Send Console Command";
            metroSetButton11.ThemeAuthor = "Narwin";
            metroSetButton11.ThemeName = "MetroDark";
            metroSetButton11.Click += metroSetButton11_Click;
            // 
            // metroSetButton8
            // 
            metroSetButton8.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton8.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton8.DisabledForeColor = Color.Gray;
            metroSetButton8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton8.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton8.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton8.HoverTextColor = Color.White;
            metroSetButton8.IsDerivedStyle = true;
            metroSetButton8.Location = new Point(225, 114);
            metroSetButton8.Name = "metroSetButton8";
            metroSetButton8.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton8.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton8.NormalTextColor = Color.White;
            metroSetButton8.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton8.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton8.PressTextColor = Color.White;
            metroSetButton8.Size = new Size(146, 31);
            metroSetButton8.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton8.StyleManager = styleManager1;
            metroSetButton8.TabIndex = 8;
            metroSetButton8.Text = "Wide FOV: OFF";
            metroSetButton8.ThemeAuthor = "Narwin";
            metroSetButton8.ThemeName = "MetroDark";
            metroSetButton8.Click += metroSetButton8_Click;
            // 
            // metroSetButton7
            // 
            metroSetButton7.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton7.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton7.DisabledForeColor = Color.Gray;
            metroSetButton7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton7.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton7.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton7.HoverTextColor = Color.White;
            metroSetButton7.IsDerivedStyle = true;
            metroSetButton7.Location = new Point(225, 151);
            metroSetButton7.Name = "metroSetButton7";
            metroSetButton7.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton7.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton7.NormalTextColor = Color.White;
            metroSetButton7.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton7.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton7.PressTextColor = Color.White;
            metroSetButton7.Size = new Size(146, 31);
            metroSetButton7.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton7.StyleManager = styleManager1;
            metroSetButton7.TabIndex = 7;
            metroSetButton7.Text = "XXL Orb Size: OFF";
            metroSetButton7.ThemeAuthor = "Narwin";
            metroSetButton7.ThemeName = "MetroDark";
            metroSetButton7.Click += metroSetButton7_Click;
            // 
            // metroSetButton6
            // 
            metroSetButton6.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton6.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton6.DisabledForeColor = Color.Gray;
            metroSetButton6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton6.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton6.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton6.HoverTextColor = Color.White;
            metroSetButton6.IsDerivedStyle = true;
            metroSetButton6.Location = new Point(225, 77);
            metroSetButton6.Name = "metroSetButton6";
            metroSetButton6.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton6.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton6.NormalTextColor = Color.White;
            metroSetButton6.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton6.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton6.PressTextColor = Color.White;
            metroSetButton6.Size = new Size(146, 31);
            metroSetButton6.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton6.StyleManager = styleManager1;
            metroSetButton6.TabIndex = 6;
            metroSetButton6.Text = "Disable Bullets: OFF";
            metroSetButton6.ThemeAuthor = "Narwin";
            metroSetButton6.ThemeName = "MetroDark";
            metroSetButton6.Click += metroSetButton6_Click;
            // 
            // metroSetButton5
            // 
            metroSetButton5.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton5.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton5.DisabledForeColor = Color.Gray;
            metroSetButton5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton5.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton5.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton5.HoverTextColor = Color.White;
            metroSetButton5.IsDerivedStyle = true;
            metroSetButton5.Location = new Point(225, 40);
            metroSetButton5.Name = "metroSetButton5";
            metroSetButton5.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton5.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton5.NormalTextColor = Color.White;
            metroSetButton5.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton5.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton5.PressTextColor = Color.White;
            metroSetButton5.Size = new Size(146, 31);
            metroSetButton5.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton5.StyleManager = styleManager1;
            metroSetButton5.TabIndex = 5;
            metroSetButton5.Text = "Super Run: OFF";
            metroSetButton5.ThemeAuthor = "Narwin";
            metroSetButton5.ThemeName = "MetroDark";
            metroSetButton5.Click += metroSetButton5_Click;
            // 
            // metroSetButton4
            // 
            metroSetButton4.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton4.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton4.DisabledForeColor = Color.Gray;
            metroSetButton4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton4.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton4.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton4.HoverTextColor = Color.White;
            metroSetButton4.IsDerivedStyle = true;
            metroSetButton4.Location = new Point(225, 3);
            metroSetButton4.Name = "metroSetButton4";
            metroSetButton4.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton4.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton4.NormalTextColor = Color.White;
            metroSetButton4.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton4.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton4.PressTextColor = Color.White;
            metroSetButton4.Size = new Size(146, 31);
            metroSetButton4.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton4.StyleManager = styleManager1;
            metroSetButton4.TabIndex = 4;
            metroSetButton4.Text = "Speedy Cars: OFF";
            metroSetButton4.ThemeAuthor = "Narwin";
            metroSetButton4.ThemeName = "MetroDark";
            metroSetButton4.Click += metroSetButton4_Click;
            // 
            // metroSetButton2
            // 
            metroSetButton2.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton2.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton2.DisabledForeColor = Color.Gray;
            metroSetButton2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton2.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton2.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton2.HoverTextColor = Color.White;
            metroSetButton2.IsDerivedStyle = true;
            metroSetButton2.Location = new Point(3, 40);
            metroSetButton2.Name = "metroSetButton2";
            metroSetButton2.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton2.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton2.NormalTextColor = Color.White;
            metroSetButton2.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton2.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton2.PressTextColor = Color.White;
            metroSetButton2.Size = new Size(146, 31);
            metroSetButton2.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton2.StyleManager = styleManager1;
            metroSetButton2.TabIndex = 2;
            metroSetButton2.Text = "Infinite Ammo: OFF";
            metroSetButton2.ThemeAuthor = "Narwin";
            metroSetButton2.ThemeName = "MetroDark";
            metroSetButton2.Click += metroSetButton2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // metroSetButton1
            // 
            metroSetButton1.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton1.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton1.DisabledForeColor = Color.Gray;
            metroSetButton1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton1.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton1.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton1.HoverTextColor = Color.White;
            metroSetButton1.IsDerivedStyle = true;
            metroSetButton1.Location = new Point(15, 90);
            metroSetButton1.Name = "metroSetButton1";
            metroSetButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton1.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton1.NormalTextColor = Color.White;
            metroSetButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton1.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton1.PressTextColor = Color.White;
            metroSetButton1.Size = new Size(153, 31);
            metroSetButton1.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton1.StyleManager = styleManager1;
            metroSetButton1.TabIndex = 0;
            metroSetButton1.Text = "Connect";
            metroSetButton1.ThemeAuthor = "Narwin";
            metroSetButton1.ThemeName = "MetroDark";
            metroSetButton1.Click += metroSetButton1_Click;
            // 
            // metroSetButton9
            // 
            metroSetButton9.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton9.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSetButton9.DisabledForeColor = Color.Gray;
            metroSetButton9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetButton9.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroSetButton9.HoverColor = Color.FromArgb(95, 207, 255);
            metroSetButton9.HoverTextColor = Color.White;
            metroSetButton9.IsDerivedStyle = true;
            metroSetButton9.Location = new Point(188, 90);
            metroSetButton9.Name = "metroSetButton9";
            metroSetButton9.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetButton9.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetButton9.NormalTextColor = Color.White;
            metroSetButton9.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroSetButton9.PressColor = Color.FromArgb(35, 147, 195);
            metroSetButton9.PressTextColor = Color.White;
            metroSetButton9.Size = new Size(153, 31);
            metroSetButton9.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetButton9.StyleManager = styleManager1;
            metroSetButton9.TabIndex = 4;
            metroSetButton9.Text = "Load Crackdown";
            metroSetButton9.ThemeAuthor = "Narwin";
            metroSetButton9.ThemeName = "MetroDark";
            metroSetButton9.Click += metroSetButton9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(metroSetButton9);
            Controls.Add(metroSetTabControl1);
            Controls.Add(metroSetLabel2);
            Controls.Add(metroSetLabel1);
            Controls.Add(metroSetButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Style = MetroSet_UI.Enums.Style.Dark;
            StyleManager = styleManager1;
            Text = "Crackdown Mod Tool";
            TextColor = Color.White;
            ThemeName = "MetroDark";
            Load += Form1_Load;
            metroSetTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private TabPage tabPage1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private System.Windows.Forms.Timer timer1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton4;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton5;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton6;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton7;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton8;
        private System.Windows.Forms.Timer timer2;
        private TextBox textBox1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton11;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton3;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton10;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton12;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton9;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private TextBox textBox2;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton14;
    }
}