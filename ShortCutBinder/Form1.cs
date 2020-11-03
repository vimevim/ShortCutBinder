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

namespace ShortCutBinder
{
    public partial class Form1 : Form
    {
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

        //timer tick oldukça pencere ismini label2ye yazdır
        private void timer1_Tick(object sender, EventArgs e)
        {
            string windowTitle = "asd - " + GetActiveWindowTitle();
            string[] split = windowTitle.Split('-');
            label2.Text =split.Last().Trim().ToLower();
        }

        //notifyicon'a çift tıklayınca label2 içeriği defkey.com'da aratılıyor
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string deneme = label2.Text.Replace(" ", "+");
            label2.Text = deneme;
            System.Diagnostics.Process.Start("https://defkey.com/tr/arama?irq=" + deneme);
        }
    }
}
