namespace WindowsFormsExamples
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
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.btn_ortalamaHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ortalamaSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Notunuzu Giriniz: ";
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.Location = new System.Drawing.Point(249, 106);
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(139, 20);
            this.txt_birinciNot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Notunuzu Giriniz: ";
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.Location = new System.Drawing.Point(249, 151);
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(139, 20);
            this.txt_ikinciNot.TabIndex = 1;
            // 
            // btn_ortalamaHesapla
            // 
            this.btn_ortalamaHesapla.Location = new System.Drawing.Point(249, 216);
            this.btn_ortalamaHesapla.Name = "btn_ortalamaHesapla";
            this.btn_ortalamaHesapla.Size = new System.Drawing.Size(139, 38);
            this.btn_ortalamaHesapla.TabIndex = 2;
            this.btn_ortalamaHesapla.Text = "Ortalamayı Bul";
            this.btn_ortalamaHesapla.UseVisualStyleBackColor = true;
            this.btn_ortalamaHesapla.Click += new System.EventHandler(this.btn_ortalamaHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(245, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ortalama: ";
            // 
            // lbl_ortalamaSonuc
            // 
            this.lbl_ortalamaSonuc.AutoSize = true;
            this.lbl_ortalamaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ortalamaSonuc.Location = new System.Drawing.Point(344, 282);
            this.lbl_ortalamaSonuc.Name = "lbl_ortalamaSonuc";
            this.lbl_ortalamaSonuc.Size = new System.Drawing.Size(17, 18);
            this.lbl_ortalamaSonuc.TabIndex = 0;
            this.lbl_ortalamaSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 431);
            this.Controls.Add(this.btn_ortalamaHesapla);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.lbl_ortalamaSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birinciNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikinciNot;
        private System.Windows.Forms.Button btn_ortalamaHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ortalamaSonuc;
    }
}

