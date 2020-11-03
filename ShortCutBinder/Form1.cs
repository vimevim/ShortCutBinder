using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace ShortCutBinder
{
    public partial class Form1 : Form
    {
        bool show = true;
        //pencere ismi almaya yarayan fonksiyonlar
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //timer tick oldukça üzerinde çalışılan pencere ismi label2ye yazdır
        private void timer1_Tick(object sender, EventArgs e)
        {
            string windowTitle = "asd - " + GetActiveWindowTitle();
            string[] split = windowTitle.Split('-');
            label2.Text = split.Last().Trim().ToLower();
        }

        //notifyicon'a çift tıklayınca label2 içeriği defkey.com'da aratılıyor
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = label2.Text.Replace(" ", "+");
            System.Diagnostics.Process.Start("https://defkey.com/tr/arama?irq=" + label2.Text);
        }

        //run at startup komutları
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("ShortCutBinder").ToString() == "\"" + Application.ExecutablePath + "\"")
                { // Eğer regeditte varsa, checkbox ı işaretle
                    runAtStartUp.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void runAtStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (runAtStartUp.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("ShortCutBinder", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("ShortCutBinder");
            }
        }

        //pencereyi hareket ettirme fonksiyonları
        int panelGuiderLeft, panelGuiderTop;
        private void panelGuider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelGuiderLeft = e.X;
                panelGuiderTop = e.Y;
            }
        }

        //this.hide this.show komutları için metod
        private void Visibility()
        {
            if (show == true)
            {
                this.Hide();
                show = false;
            }
            else if (show == false)
            {
                this.Show();
                show = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Visibility();
        }

        private void panelGuider_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visibility();
        }

        private void panelGuider_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = Cursor.Position.X - panelGuiderLeft;
                this.Top = Cursor.Position.Y - panelGuiderTop;
            }
        }
    }
}
