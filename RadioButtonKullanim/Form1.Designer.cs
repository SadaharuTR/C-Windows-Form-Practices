namespace RadioButtonKullanim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soyadınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adınız:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(153, 24);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(153, 69);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(98, 139);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(53, 17);
            this.radio_erkek.TabIndex = 2;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Location = new System.Drawing.Point(201, 139);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(52, 17);
            this.radio_kadin.TabIndex = 3;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(98, 175);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(155, 31);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 256);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.radio_kadin);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_kadin;
        private System.Windows.Forms.Button btn_yazdir;
    }
}

