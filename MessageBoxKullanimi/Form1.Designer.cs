namespace MessageBoxKullanimi
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
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonuç: ";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(230, 110);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(10, 15);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = ".";
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.Location = new System.Drawing.Point(165, 185);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(75, 23);
            this.btn_cikisyap.TabIndex = 1;
            this.btn_cikisyap.Text = "Benjamin";
            this.btn_cikisyap.UseVisualStyleBackColor = true;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çıkış yapmak için Benjamin Button\'a basın.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.Label label2;
    }
}

