namespace ChuyenCoSo
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
            this.label_Nhap = new System.Windows.Forms.Label();
            this.tb_Nhap = new System.Windows.Forms.TextBox();
            this.decTobin = new System.Windows.Forms.Button();
            this.decTooct = new System.Windows.Forms.Button();
            this.decTohex = new System.Windows.Forms.Button();
            this.binTodec = new System.Windows.Forms.Button();
            this.binTooct = new System.Windows.Forms.Button();
            this.binTohex = new System.Windows.Forms.Button();
            this.octTodec = new System.Windows.Forms.Button();
            this.octTobin = new System.Windows.Forms.Button();
            this.octTohex = new System.Windows.Forms.Button();
            this.hexTodec = new System.Windows.Forms.Button();
            this.label_Xuat = new System.Windows.Forms.Label();
            this.hexTobin = new System.Windows.Forms.Button();
            this.hexTooct = new System.Windows.Forms.Button();
            this.tb_Xuat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Nhap
            // 
            this.label_Nhap.AutoSize = true;
            this.label_Nhap.Location = new System.Drawing.Point(102, 48);
            this.label_Nhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nhap.Name = "label_Nhap";
            this.label_Nhap.Size = new System.Drawing.Size(33, 13);
            this.label_Nhap.TabIndex = 0;
            this.label_Nhap.Text = "Nhập";
            // 
            // tb_Nhap
            // 
            this.tb_Nhap.Location = new System.Drawing.Point(163, 45);
            this.tb_Nhap.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Nhap.Name = "tb_Nhap";
            this.tb_Nhap.Size = new System.Drawing.Size(161, 20);
            this.tb_Nhap.TabIndex = 1;
            // 
            // decTobin
            // 
            this.decTobin.Location = new System.Drawing.Point(42, 95);
            this.decTobin.Margin = new System.Windows.Forms.Padding(2);
            this.decTobin.Name = "decTobin";
            this.decTobin.Size = new System.Drawing.Size(65, 23);
            this.decTobin.TabIndex = 2;
            this.decTobin.Text = "Dec->Bin";
            this.decTobin.UseVisualStyleBackColor = true;
            this.decTobin.Click += new System.EventHandler(this.decTobin_Click);
            // 
            // decTooct
            // 
            this.decTooct.Location = new System.Drawing.Point(42, 135);
            this.decTooct.Margin = new System.Windows.Forms.Padding(2);
            this.decTooct.Name = "decTooct";
            this.decTooct.Size = new System.Drawing.Size(65, 23);
            this.decTooct.TabIndex = 3;
            this.decTooct.Text = "Dec->Oct";
            this.decTooct.UseVisualStyleBackColor = true;
            this.decTooct.Click += new System.EventHandler(this.decTooct_Click);
            // 
            // decTohex
            // 
            this.decTohex.Location = new System.Drawing.Point(42, 174);
            this.decTohex.Margin = new System.Windows.Forms.Padding(2);
            this.decTohex.Name = "decTohex";
            this.decTohex.Size = new System.Drawing.Size(65, 21);
            this.decTohex.TabIndex = 4;
            this.decTohex.Text = "Dec->Hex";
            this.decTohex.UseVisualStyleBackColor = true;
            this.decTohex.Click += new System.EventHandler(this.decTohex_Click);
            // 
            // binTodec
            // 
            this.binTodec.Location = new System.Drawing.Point(147, 95);
            this.binTodec.Margin = new System.Windows.Forms.Padding(2);
            this.binTodec.Name = "binTodec";
            this.binTodec.Size = new System.Drawing.Size(83, 23);
            this.binTodec.TabIndex = 5;
            this.binTodec.Text = "Bin->Dec";
            this.binTodec.UseVisualStyleBackColor = true;
            this.binTodec.Click += new System.EventHandler(this.binTodec_Click);
            // 
            // binTooct
            // 
            this.binTooct.Location = new System.Drawing.Point(147, 135);
            this.binTooct.Margin = new System.Windows.Forms.Padding(2);
            this.binTooct.Name = "binTooct";
            this.binTooct.Size = new System.Drawing.Size(83, 23);
            this.binTooct.TabIndex = 6;
            this.binTooct.Text = "Bin->Oct";
            this.binTooct.UseVisualStyleBackColor = true;
            this.binTooct.Click += new System.EventHandler(this.binTooct_Click);
            // 
            // binTohex
            // 
            this.binTohex.Location = new System.Drawing.Point(147, 174);
            this.binTohex.Margin = new System.Windows.Forms.Padding(2);
            this.binTohex.Name = "binTohex";
            this.binTohex.Size = new System.Drawing.Size(83, 21);
            this.binTohex.TabIndex = 7;
            this.binTohex.Text = "Bin->Hex";
            this.binTohex.UseVisualStyleBackColor = true;
            this.binTohex.Click += new System.EventHandler(this.binTohex_Click);
            // 
            // octTodec
            // 
            this.octTodec.Location = new System.Drawing.Point(262, 95);
            this.octTodec.Margin = new System.Windows.Forms.Padding(2);
            this.octTodec.Name = "octTodec";
            this.octTodec.Size = new System.Drawing.Size(73, 23);
            this.octTodec.TabIndex = 8;
            this.octTodec.Text = "Oct->Dec";
            this.octTodec.UseVisualStyleBackColor = true;
            this.octTodec.Click += new System.EventHandler(this.octTodec_Click);
            // 
            // octTobin
            // 
            this.octTobin.Location = new System.Drawing.Point(262, 135);
            this.octTobin.Margin = new System.Windows.Forms.Padding(2);
            this.octTobin.Name = "octTobin";
            this.octTobin.Size = new System.Drawing.Size(73, 23);
            this.octTobin.TabIndex = 9;
            this.octTobin.Text = "Oct->Bin";
            this.octTobin.UseVisualStyleBackColor = true;
            this.octTobin.Click += new System.EventHandler(this.octTobin_Click);
            // 
            // octTohex
            // 
            this.octTohex.Location = new System.Drawing.Point(262, 174);
            this.octTohex.Margin = new System.Windows.Forms.Padding(2);
            this.octTohex.Name = "octTohex";
            this.octTohex.Size = new System.Drawing.Size(73, 21);
            this.octTohex.TabIndex = 10;
            this.octTohex.Text = "Oct->Hex";
            this.octTohex.UseVisualStyleBackColor = true;
            this.octTohex.Click += new System.EventHandler(this.octTohex_Click);
            // 
            // hexTodec
            // 
            this.hexTodec.Location = new System.Drawing.Point(367, 95);
            this.hexTodec.Margin = new System.Windows.Forms.Padding(2);
            this.hexTodec.Name = "hexTodec";
            this.hexTodec.Size = new System.Drawing.Size(63, 23);
            this.hexTodec.TabIndex = 11;
            this.hexTodec.Text = "Hex->Dec";
            this.hexTodec.UseVisualStyleBackColor = true;
            this.hexTodec.Click += new System.EventHandler(this.hexTodec_Click);
            // 
            // label_Xuat
            // 
            this.label_Xuat.AutoSize = true;
            this.label_Xuat.Location = new System.Drawing.Point(102, 225);
            this.label_Xuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Xuat.Name = "label_Xuat";
            this.label_Xuat.Size = new System.Drawing.Size(44, 13);
            this.label_Xuat.TabIndex = 12;
            this.label_Xuat.Text = "Kết quả";
            // 
            // hexTobin
            // 
            this.hexTobin.Location = new System.Drawing.Point(367, 135);
            this.hexTobin.Margin = new System.Windows.Forms.Padding(2);
            this.hexTobin.Name = "hexTobin";
            this.hexTobin.Size = new System.Drawing.Size(63, 23);
            this.hexTobin.TabIndex = 13;
            this.hexTobin.Text = "Hex->Bin";
            this.hexTobin.UseVisualStyleBackColor = true;
            this.hexTobin.Click += new System.EventHandler(this.hexTobin_Click);
            // 
            // hexTooct
            // 
            this.hexTooct.Location = new System.Drawing.Point(367, 174);
            this.hexTooct.Margin = new System.Windows.Forms.Padding(2);
            this.hexTooct.Name = "hexTooct";
            this.hexTooct.Size = new System.Drawing.Size(63, 21);
            this.hexTooct.TabIndex = 14;
            this.hexTooct.Text = "Hex->Oct";
            this.hexTooct.UseVisualStyleBackColor = true;
            this.hexTooct.Click += new System.EventHandler(this.hexTooct_Click);
            // 
            // tb_Xuat
            // 
            this.tb_Xuat.Location = new System.Drawing.Point(163, 222);
            this.tb_Xuat.Name = "tb_Xuat";
            this.tb_Xuat.Size = new System.Drawing.Size(161, 20);
            this.tb_Xuat.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 285);
            this.Controls.Add(this.tb_Xuat);
            this.Controls.Add(this.hexTooct);
            this.Controls.Add(this.hexTobin);
            this.Controls.Add(this.label_Xuat);
            this.Controls.Add(this.hexTodec);
            this.Controls.Add(this.octTohex);
            this.Controls.Add(this.octTobin);
            this.Controls.Add(this.octTodec);
            this.Controls.Add(this.binTohex);
            this.Controls.Add(this.binTooct);
            this.Controls.Add(this.binTodec);
            this.Controls.Add(this.decTohex);
            this.Controls.Add(this.decTooct);
            this.Controls.Add(this.decTobin);
            this.Controls.Add(this.tb_Nhap);
            this.Controls.Add(this.label_Nhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Chuyển Cơ Số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nhap;
        private System.Windows.Forms.TextBox tb_Nhap;
        private System.Windows.Forms.Button decTobin;
        private System.Windows.Forms.Button decTooct;
        private System.Windows.Forms.Button decTohex;
        private System.Windows.Forms.Button binTodec;
        private System.Windows.Forms.Button binTooct;
        private System.Windows.Forms.Button binTohex;
        private System.Windows.Forms.Button octTodec;
        private System.Windows.Forms.Button octTobin;
        private System.Windows.Forms.Button octTohex;
        private System.Windows.Forms.Button hexTodec;
        private System.Windows.Forms.Label label_Xuat;
        private System.Windows.Forms.Button hexTobin;
        private System.Windows.Forms.Button hexTooct;
        private System.Windows.Forms.TextBox tb_Xuat;
    }
}

