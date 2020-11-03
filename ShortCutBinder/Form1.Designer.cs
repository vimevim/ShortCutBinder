namespace ShortCutBinder
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runAtStartUp = new System.Windows.Forms.CheckBox();
            this.panelGuider = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uygulama Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // runAtStartUp
            // 
            this.runAtStartUp.AutoSize = true;
            this.runAtStartUp.Location = new System.Drawing.Point(30, 99);
            this.runAtStartUp.Margin = new System.Windows.Forms.Padding(2);
            this.runAtStartUp.Name = "runAtStartUp";
            this.runAtStartUp.Size = new System.Drawing.Size(114, 17);
            this.runAtStartUp.TabIndex = 20;
            this.runAtStartUp.Text = "Başlangıçta Çalıştır";
            this.runAtStartUp.UseVisualStyleBackColor = true;
            this.runAtStartUp.CheckedChanged += new System.EventHandler(this.runAtStartUp_CheckedChanged);
            // 
            // panelGuider
            // 
            this.panelGuider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.panelGuider.Location = new System.Drawing.Point(0, 0);
            this.panelGuider.Margin = new System.Windows.Forms.Padding(2);
            this.panelGuider.Name = "panelGuider";
            this.panelGuider.Size = new System.Drawing.Size(400, 41);
            this.panelGuider.TabIndex = 21;
            this.panelGuider.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelGuider_MouseDoubleClick);
            this.panelGuider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGuider_MouseDown);
            this.panelGuider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGuider_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelGuider);
            this.Controls.Add(this.runAtStartUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox runAtStartUp;
        private System.Windows.Forms.Panel panelGuider;
    }
}

