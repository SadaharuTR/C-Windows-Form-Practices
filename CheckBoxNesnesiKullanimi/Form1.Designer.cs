namespace CheckBoxNesnesiKullanimi
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
            this.checkBox_cay = new System.Windows.Forms.CheckBox();
            this.checkBox_kahve = new System.Windows.Forms.CheckBox();
            this.checkBox_burger = new System.Windows.Forms.CheckBox();
            this.checkBox_pizza = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_cay
            // 
            this.checkBox_cay.AutoSize = true;
            this.checkBox_cay.Location = new System.Drawing.Point(164, 63);
            this.checkBox_cay.Name = "checkBox_cay";
            this.checkBox_cay.Size = new System.Drawing.Size(69, 17);
            this.checkBox_cay.TabIndex = 0;
            this.checkBox_cay.Text = "Çay 2 TL";
            this.checkBox_cay.UseVisualStyleBackColor = true;
            // 
            // checkBox_kahve
            // 
            this.checkBox_kahve.AutoSize = true;
            this.checkBox_kahve.Location = new System.Drawing.Point(164, 86);
            this.checkBox_kahve.Name = "checkBox_kahve";
            this.checkBox_kahve.Size = new System.Drawing.Size(82, 17);
            this.checkBox_kahve.TabIndex = 0;
            this.checkBox_kahve.Text = "Kahve 4 TL";
            this.checkBox_kahve.UseVisualStyleBackColor = true;
            // 
            // checkBox_burger
            // 
            this.checkBox_burger.AutoSize = true;
            this.checkBox_burger.Location = new System.Drawing.Point(164, 109);
            this.checkBox_burger.Name = "checkBox_burger";
            this.checkBox_burger.Size = new System.Drawing.Size(109, 17);
            this.checkBox_burger.TabIndex = 0;
            this.checkBox_burger.Text = "Hamburger 10 TL";
            this.checkBox_burger.UseVisualStyleBackColor = true;
            // 
            // checkBox_pizza
            // 
            this.checkBox_pizza.AutoSize = true;
            this.checkBox_pizza.Location = new System.Drawing.Point(164, 132);
            this.checkBox_pizza.Name = "checkBox_pizza";
            this.checkBox_pizza.Size = new System.Drawing.Size(82, 17);
            this.checkBox_pizza.TabIndex = 0;
            this.checkBox_pizza.Text = "Pizza 25 TL";
            this.checkBox_pizza.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(164, 207);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(109, 31);
            this.btn_hesapla.TabIndex = 1;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(349, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar:";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.Location = new System.Drawing.Point(422, 63);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(37, 18);
            this.lbl_tutar.TabIndex = 2;
            this.lbl_tutar.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.checkBox_pizza);
            this.Controls.Add(this.checkBox_burger);
            this.Controls.Add(this.checkBox_kahve);
            this.Controls.Add(this.checkBox_cay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_cay;
        private System.Windows.Forms.CheckBox checkBox_kahve;
        private System.Windows.Forms.CheckBox checkBox_burger;
        private System.Windows.Forms.CheckBox checkBox_pizza;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tutar;
    }
}

