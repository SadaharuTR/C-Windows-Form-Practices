namespace WebBrowserKullanimi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_git = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_yenile);
            this.panel1.Controls.Add(this.btn_ileri);
            this.panel1.Controls.Add(this.btn_geri);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(0, 0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(61, 45);
            this.btn_geri.TabIndex = 0;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ileri.Location = new System.Drawing.Point(62, 0);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(61, 45);
            this.btn_ileri.TabIndex = 0;
            this.btn_ileri.Text = ">";
            this.btn_ileri.UseVisualStyleBackColor = false;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.Location = new System.Drawing.Point(126, 0);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(61, 45);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "R";
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(199, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 45);
            this.textBox1.TabIndex = 1;
            // 
            // btn_git
            // 
            this.btn_git.BackColor = System.Drawing.Color.IndianRed;
            this.btn_git.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_git.Location = new System.Drawing.Point(3, 1);
            this.btn_git.Name = "btn_git";
            this.btn_git.Size = new System.Drawing.Size(85, 45);
            this.btn_git.TabIndex = 0;
            this.btn_git.Text = "Git";
            this.btn_git.UseVisualStyleBackColor = false;
            this.btn_git.Click += new System.EventHandler(this.btn_git_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_git);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(706, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 48);
            this.panel2.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(801, 410);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 461);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_git;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

