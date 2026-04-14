namespace Lab5._2
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
            this.Nhaphesoa = new System.Windows.Forms.Label();
            this.Nhaphesob = new System.Windows.Forms.Label();
            this.Nhaphesoc = new System.Windows.Forms.Label();
            this.Giai = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Nghiem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Hesoa = new System.Windows.Forms.TextBox();
            this.hesob = new System.Windows.Forms.TextBox();
            this.hesoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nhaphesoa
            // 
            this.Nhaphesoa.AutoSize = true;
            this.Nhaphesoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhaphesoa.Location = new System.Drawing.Point(27, 46);
            this.Nhaphesoa.Name = "Nhaphesoa";
            this.Nhaphesoa.Size = new System.Drawing.Size(175, 29);
            this.Nhaphesoa.TabIndex = 0;
            this.Nhaphesoa.Text = "Nhập hệ số a";
            // 
            // Nhaphesob
            // 
            this.Nhaphesob.AutoSize = true;
            this.Nhaphesob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhaphesob.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nhaphesob.Location = new System.Drawing.Point(27, 141);
            this.Nhaphesob.Name = "Nhaphesob";
            this.Nhaphesob.Size = new System.Drawing.Size(175, 29);
            this.Nhaphesob.TabIndex = 1;
            this.Nhaphesob.Text = "Nhập hệ số b";
            // 
            // Nhaphesoc
            // 
            this.Nhaphesoc.AutoSize = true;
            this.Nhaphesoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhaphesoc.Location = new System.Drawing.Point(27, 238);
            this.Nhaphesoc.Name = "Nhaphesoc";
            this.Nhaphesoc.Size = new System.Drawing.Size(174, 29);
            this.Nhaphesoc.TabIndex = 2;
            this.Nhaphesoc.Text = "Nhập hệ số c";
            // 
            // Giai
            // 
            this.Giai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giai.Location = new System.Drawing.Point(46, 331);
            this.Giai.Name = "Giai";
            this.Giai.Size = new System.Drawing.Size(120, 50);
            this.Giai.TabIndex = 3;
            this.Giai.Text = "Giải";
            this.Giai.UseVisualStyleBackColor = true;
            this.Giai.Click += new System.EventHandler(this.Giai_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(198, 331);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(128, 50);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Nghiem
            // 
            this.Nghiem.AutoSize = true;
            this.Nghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nghiem.Location = new System.Drawing.Point(397, 46);
            this.Nghiem.Name = "Nghiem";
            this.Nghiem.Size = new System.Drawing.Size(335, 29);
            this.Nghiem.TabIndex = 5;
            this.Nghiem.Text = "Nghiệm của phương trình :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 6;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Hesoa
            // 
            this.Hesoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hesoa.Location = new System.Drawing.Point(222, 36);
            this.Hesoa.Name = "Hesoa";
            this.Hesoa.Size = new System.Drawing.Size(104, 45);
            this.Hesoa.TabIndex = 7;
            // 
            // hesob
            // 
            this.hesob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesob.Location = new System.Drawing.Point(224, 132);
            this.hesob.Name = "hesob";
            this.hesob.Size = new System.Drawing.Size(100, 45);
            this.hesob.TabIndex = 8;
            // 
            // hesoc
            // 
            this.hesoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesoc.Location = new System.Drawing.Point(222, 228);
            this.hesoc.Name = "hesoc";
            this.hesoc.Size = new System.Drawing.Size(100, 45);
            this.hesoc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(402, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 263);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesoc);
            this.Controls.Add(this.hesob);
            this.Controls.Add(this.Hesoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nghiem);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Giai);
            this.Controls.Add(this.Nhaphesoc);
            this.Controls.Add(this.Nhaphesob);
            this.Controls.Add(this.Nhaphesoa);
            this.Name = "Form1";
            this.Text = "Lab5 - 5.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nhaphesoa;
        private System.Windows.Forms.Label Nhaphesob;
        private System.Windows.Forms.Label Nhaphesoc;
        private System.Windows.Forms.Button Giai;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label Nghiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Hesoa;
        private System.Windows.Forms.TextBox hesob;
        private System.Windows.Forms.TextBox hesoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

