namespace Giải_Phương_Trình
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptb2 = new System.Windows.Forms.RadioButton();
            this.ptb1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.thoat = new System.Windows.Forms.Button();
            this.giai = new System.Windows.Forms.Button();
            this.lablekq = new System.Windows.Forms.Label();
            this.labelpt = new System.Windows.Forms.Label();
            this.lablec = new System.Windows.Forms.Label();
            this.lableb = new System.Windows.Forms.Label();
            this.lablea = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.TextBox();
            this.pt = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptb2);
            this.groupBox1.Controls.Add(this.ptb1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(27, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỌN LOẠI PHƯƠNG TRÌNH CẦN GIẢI";
            // 
            // ptb2
            // 
            this.ptb2.AutoSize = true;
            this.ptb2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptb2.Location = new System.Drawing.Point(18, 62);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(202, 23);
            this.ptb2.TabIndex = 1;
            this.ptb2.TabStop = true;
            this.ptb2.Text = "PHƯƠNG TRÌNH BẬC 2";
            this.ptb2.UseVisualStyleBackColor = true;
            this.ptb2.CheckedChanged += new System.EventHandler(this.ptb2_CheckedChanged_1);
            // 
            // ptb1
            // 
            this.ptb1.AutoSize = true;
            this.ptb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptb1.Location = new System.Drawing.Point(18, 21);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(202, 23);
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = true;
            this.ptb1.Text = "PHƯƠNG TRÌNH BẬC 1";
            this.ptb1.UseVisualStyleBackColor = true;
            this.ptb1.CheckedChanged += new System.EventHandler(this.ptb1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(358, 210);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 56);
            this.thoat.TabIndex = 41;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // giai
            // 
            this.giai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giai.Location = new System.Drawing.Point(277, 210);
            this.giai.Name = "giai";
            this.giai.Size = new System.Drawing.Size(75, 56);
            this.giai.TabIndex = 40;
            this.giai.Text = "GIẢI";
            this.giai.UseVisualStyleBackColor = true;
            this.giai.Click += new System.EventHandler(this.giai_Click_1);
            // 
            // lablekq
            // 
            this.lablekq.AutoSize = true;
            this.lablekq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablekq.Location = new System.Drawing.Point(27, 342);
            this.lablekq.Name = "lablekq";
            this.lablekq.Size = new System.Drawing.Size(53, 16);
            this.lablekq.TabIndex = 39;
            this.lablekq.Text = "Kết quả";
            // 
            // labelpt
            // 
            this.labelpt.AutoSize = true;
            this.labelpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpt.Location = new System.Drawing.Point(27, 307);
            this.labelpt.Name = "labelpt";
            this.labelpt.Size = new System.Drawing.Size(133, 16);
            this.labelpt.TabIndex = 38;
            this.labelpt.Text = "Phương trình có dạng";
            // 
            // lablec
            // 
            this.lablec.AutoSize = true;
            this.lablec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablec.Location = new System.Drawing.Point(27, 270);
            this.lablec.Name = "lablec";
            this.lablec.Size = new System.Drawing.Size(51, 16);
            this.lablec.TabIndex = 37;
            this.lablec.Text = "Nhập c";
            // 
            // lableb
            // 
            this.lableb.AutoSize = true;
            this.lableb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableb.Location = new System.Drawing.Point(27, 234);
            this.lableb.Name = "lableb";
            this.lableb.Size = new System.Drawing.Size(52, 16);
            this.lableb.TabIndex = 36;
            this.lableb.Text = "Nhập b";
            // 
            // lablea
            // 
            this.lablea.AutoSize = true;
            this.lablea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablea.Location = new System.Drawing.Point(27, 194);
            this.lablea.Name = "lablea";
            this.lablea.Size = new System.Drawing.Size(52, 16);
            this.lablea.TabIndex = 35;
            this.lablea.Text = "Nhập a";
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(166, 335);
            this.kq.Multiline = true;
            this.kq.Name = "kq";
            this.kq.ReadOnly = true;
            this.kq.Size = new System.Drawing.Size(267, 48);
            this.kq.TabIndex = 34;
            // 
            // pt
            // 
            this.pt.Location = new System.Drawing.Point(166, 303);
            this.pt.Name = "pt";
            this.pt.ReadOnly = true;
            this.pt.Size = new System.Drawing.Size(267, 20);
            this.pt.TabIndex = 33;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(166, 266);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 32;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(166, 230);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 31;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(166, 190);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.giai);
            this.Controls.Add(this.lablekq);
            this.Controls.Add(this.labelpt);
            this.Controls.Add(this.lablec);
            this.Controls.Add(this.lableb);
            this.Controls.Add(this.lablea);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ptb2;
        private System.Windows.Forms.RadioButton ptb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button giai;
        private System.Windows.Forms.Label lablekq;
        private System.Windows.Forms.Label labelpt;
        private System.Windows.Forms.Label lablec;
        private System.Windows.Forms.Label lableb;
        private System.Windows.Forms.Label lablea;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.TextBox pt;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
    }
}

