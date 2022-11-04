namespace ComboBoxKullanimi
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
            this.btn_gunSec = new System.Windows.Forms.Button();
            this.combo_gunler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gün seçiniz: ";
            // 
            // btn_gunSec
            // 
            this.btn_gunSec.Location = new System.Drawing.Point(223, 144);
            this.btn_gunSec.Name = "btn_gunSec";
            this.btn_gunSec.Size = new System.Drawing.Size(121, 35);
            this.btn_gunSec.TabIndex = 1;
            this.btn_gunSec.Text = "Gün Seç";
            this.btn_gunSec.UseVisualStyleBackColor = true;
            this.btn_gunSec.Click += new System.EventHandler(this.btn_gunSec_Click);
            // 
            // combo_gunler
            // 
            this.combo_gunler.FormattingEnabled = true;
            this.combo_gunler.Location = new System.Drawing.Point(223, 100);
            this.combo_gunler.Name = "combo_gunler";
            this.combo_gunler.Size = new System.Drawing.Size(121, 24);
            this.combo_gunler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_gunler);
            this.Controls.Add(this.btn_gunSec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gunSec;
        private System.Windows.Forms.ComboBox combo_gunler;
    }
}

