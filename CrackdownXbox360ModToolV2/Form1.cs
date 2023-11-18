using MetroSet_UI;
using MetroSet_UI.Forms;
using JRPC_Client;
using XDevkit;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Numerics;

/*
 * Made by DMONSKULL
 * 
 * sometimes the ammo / grenade offsets switch from 0xC6560540 to 0xC6550540 ("C656" to "C655", vice versa)
*/

namespace CrackdownXbox360ModToolV2
{
    public partial class Form1 : MetroSetForm
    {
        JRPC JRPC = new JRPC();

        public string GameFolder = ReadSpecificLine(AppDomain.CurrentDomain.BaseDirectory + "important.txt", 1);
        public string crackdown = ReadSpecificLine(AppDomain.CurrentDomain.BaseDirectory + "important.txt", 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        static string ReadSpecificLine(string filePath, int lineNumber)
        {
            string content = null;
            try
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    for (int i = 1; i < lineNumber; i++)
                    {
                        file.ReadLine();

                        if (file.EndOfStream)
                        {
                            Console.WriteLine($"End of file.  The file only contains {i} lines.");
                            break;
                        }
                    }
                    content = file.ReadLine();
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }

            return content;

        }
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            try
            {
                JRPC.Connect();
                if (JRPC.activeConnection == true)
                {
                    metroSetLabel1.Text = "Connection Found!";
                    JRPC.XNotify("Connected Successfully!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Connect", "Please check your Plugins!");
            }
        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        public bool gun1ammo;
        private void AmmoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!gun1ammo)
                {
                    AmmoButton.Text = "Gun 2 Ammo: ON";
                    JRPC.SetMemory(0xC6560540, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    JRPC.SetMemory(0xC6550540, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                }
                else
                {
                    AmmoButton.Text = "Gun 2 Ammo: OFF";
                    JRPC.SetMemory(0xC6560540, new byte[] { 0x00, 0x00, 0x00, 0x20 });
                    JRPC.SetMemory(0xC6550540, new byte[] { 0x00, 0x00, 0x00, 0x20 });
                }
                gun1ammo = !gun1ammo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        public bool gun2ammo;
        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!gun2ammo)
                {
                    metroSetButton2.Text = "Gun 1 Ammo: ON";
                    JRPC.SetMemory(0xC6560BC0, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    JRPC.SetMemory(0xC6550BC0, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                }
                else
                {
                    metroSetButton2.Text = "Gun 1 Ammo: OFF";
                    JRPC.SetMemory(0xC6560BC0, new byte[] { 0x00, 0x00, 0x00, 0xB4 });
                    JRPC.SetMemory(0xC6550BC0, new byte[] { 0x00, 0x00, 0x00, 0xB4 });
                }
                gun2ammo = !gun2ammo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        public bool grenades;
        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!grenades)
                {
                    metroSetButton3.Text = "Grenade Loop: ON";
                    timer1.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    metroSetButton3.Text = "Grenade Loop: OFF";
                    timer1.Stop();
                    timer1.Enabled = false;
                    JRPC.SetMemory(0xC6561244, new byte[] { 0x00, 0x00, 0x00, 0x07 });
                    JRPC.SetMemory(0xC6551244, new byte[] { 0x00, 0x00, 0x00, 0x07 });
                }
                grenades = !grenades;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            JRPC.SetMemory(0xC6561244, new byte[] { 0x00, 0x00, 0x00, 0x07 });
            JRPC.SetMemory(0xC6551244, new byte[] { 0x00, 0x00, 0x00, 0x07 });
        }

        private bool speedycars;
        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!speedycars)
                {
                    metroSetButton4.Text = "Speedy Cars: ON";
                    JRPC.SetMemory(0x820F634C, new byte[] { 0x42, 0xC6, 0x00, 0x00 });
                }
                else
                {
                    metroSetButton4.Text = "Speedy Cars: OFF";
                    JRPC.SetMemory(0x820F634C, new byte[] { 0xC2, 0x48, 0x00, 0x00 });
                }
                speedycars = !speedycars;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }

        }
        private bool superrun;
        private void metroSetButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!superrun)
                {
                    metroSetButton5.Text = "Super Run: ON";
                    JRPC.SetMemory(0x820F55F8, new byte[] { 0x3A, 0x22, 0x87, 0x94 });
                }
                else
                {
                    metroSetButton5.Text = "Super Run: OFF";
                    JRPC.SetMemory(0x820F55F8, new byte[] { 0x38, 0x82, 0x06, 0x10 });
                }
                superrun = !superrun;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }
        private bool disablebullets;
        private void metroSetButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!disablebullets)
                {
                    metroSetButton6.Text = "Disable Bullets: ON";
                    JRPC.SetMemory(0x82053B44, new byte[] { 0x3F, 0x80, 0x00, 0x00 });
                }
                else
                {
                    metroSetButton6.Text = "Disable Bullets: OFF";
                    JRPC.SetMemory(0x82053B44, new byte[] { 0x34, 0x00, 0x00, 0x00 });
                }
                disablebullets = !disablebullets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        private bool orbsize;
        private void metroSetButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!orbsize)
                {
                    metroSetButton7.Text = "XXL Orb Size: ON";
                    JRPC.SetMemory(0x820F6380, new byte[] { 0x42, 0xC6, 0x00, 0x00 });
                }
                else
                {
                    metroSetButton7.Text = "XXL Orb Size: OFF";
                    JRPC.SetMemory(0x820F6380, new byte[] { 0x41, 0x7F, 0x00, 0x00 });
                }
                orbsize = !orbsize;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }
        private bool widefov;
        private void metroSetButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!widefov)
                {
                    metroSetButton8.Text = "Wide FOV: ON";
                    JRPC.SetMemory(0x82070A64, new byte[] { 0x40, 0x00, 0x00, 0x00 });
                }
                else
                {
                    metroSetButton8.Text = "Wide FOV: OFF";
                    JRPC.SetMemory(0x82070A64, new byte[] { 0x3F, 0x40, 0x00, 0x00 });
                }
                widefov = !widefov;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", "Error");
            }
        }

        private void metroSetButton9_Click(object sender, EventArgs e)
        {
            try
            {
                var xexPath = @"Hdd:\" + GameFolder + "\\" + crackdown + "\\default.xex";
                JRPC.xbConsole.Reboot(xexPath, xexPath.Substring(0, xexPath.LastIndexOf(@"\", StringComparison.Ordinal)), null, XboxRebootFlags.Title);
            }

            catch (Exception) { MessageBox.Show("please connect to console first"); }
        }

        private void metroSetButton10_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string text = metroSetLabel2.Text;
            metroSetLabel2.Text = text.Substring(1) + text[0];
        }

        private void metroSetButton10_Click_1(object sender, EventArgs e)
        {

        }
    }
}