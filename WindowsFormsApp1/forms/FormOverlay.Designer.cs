namespace WindowsFormsApp1
{
    partial class FormOverlay
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverlay));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.InternetStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.ListBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.dragPanel = new Guna.UI2.WinForms.Guna2Button();
            this.AntiAfkButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(11, 19);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 42);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Заморозить процесс";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(11, 68);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(120, 42);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Отключить интернет";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(11, 119);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 42);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Включить интернет";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // InternetStatus
            // 
            this.InternetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InternetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetStatus.ForeColor = System.Drawing.Color.Black;
            this.InternetStatus.Location = new System.Drawing.Point(264, 15);
            this.InternetStatus.Name = "InternetStatus";
            this.InternetStatus.Size = new System.Drawing.Size(122, 24);
            this.InternetStatus.TabIndex = 6;
            this.InternetStatus.Text = "Без доступа";
            this.InternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Статус сети:";
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageBox.ForeColor = System.Drawing.Color.White;
            this.MessageBox.FormattingEnabled = true;
            this.MessageBox.ItemHeight = 20;
            this.MessageBox.Location = new System.Drawing.Point(145, 42);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(381, 170);
            this.MessageBox.TabIndex = 8;
            this.MessageBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MessageBox_DrawItem);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(502, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(36, 5);
            this.guna2Button4.TabIndex = 10;
            this.guna2Button4.Text = "Выйти";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dragPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dragPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dragPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dragPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dragPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dragPanel.ForeColor = System.Drawing.Color.White;
            this.dragPanel.Location = new System.Drawing.Point(0, -5);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.PressedColor = System.Drawing.Color.Transparent;
            this.dragPanel.Size = new System.Drawing.Size(505, 10);
            this.dragPanel.TabIndex = 11;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // AntiAfkButton
            // 
            this.AntiAfkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AntiAfkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AntiAfkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AntiAfkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AntiAfkButton.FillColor = System.Drawing.Color.IndianRed;
            this.AntiAfkButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AntiAfkButton.ForeColor = System.Drawing.Color.White;
            this.AntiAfkButton.Location = new System.Drawing.Point(11, 170);
            this.AntiAfkButton.Name = "AntiAfkButton";
            this.AntiAfkButton.Size = new System.Drawing.Size(120, 42);
            this.AntiAfkButton.TabIndex = 12;
            this.AntiAfkButton.Text = "АнтиАфк";
            this.AntiAfkButton.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(496, 9);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(30, 30);
            this.guna2Button5.TabIndex = 13;
            this.guna2Button5.Text = "+";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click_1);
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(538, 228);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.AntiAfkButton);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InternetStatus);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOverlay";
            this.Text = "Gta V helper by COOPER";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label InternetStatus;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox MessageBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button dragPanel;
        private Guna.UI2.WinForms.Guna2Button AntiAfkButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}

