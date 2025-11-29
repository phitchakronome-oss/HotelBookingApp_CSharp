namespace EX1_1
{
    partial class EX3_2
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
            this.LBName = new System.Windows.Forms.Label();
            this.LBSname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.BTNext = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBTypePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ-นามสกุล";
            // 
            // LBName
            // 
            this.LBName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBName.Location = new System.Drawing.Point(237, 56);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(203, 31);
            this.LBName.TabIndex = 2;
            this.LBName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBName.Click += new System.EventHandler(this.LBName_Click);
            // 
            // LBSname
            // 
            this.LBSname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSname.Location = new System.Drawing.Point(464, 56);
            this.LBSname.Name = "LBSname";
            this.LBSname.Size = new System.Drawing.Size(203, 31);
            this.LBSname.TabIndex = 3;
            this.LBSname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "วันที่จอง";
            // 
            // DTP1
            // 
            this.DTP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP1.Location = new System.Drawing.Point(241, 141);
            this.DTP1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTP1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(112, 26);
            this.DTP1.TabIndex = 5;
            // 
            // BTNext
            // 
            this.BTNext.Location = new System.Drawing.Point(358, 312);
            this.BTNext.Name = "BTNext";
            this.BTNext.Size = new System.Drawing.Size(122, 44);
            this.BTNext.TabIndex = 6;
            this.BTNext.Text = "ไปหน้าถัดไป";
            this.BTNext.UseVisualStyleBackColor = true;
            this.BTNext.Click += new System.EventHandler(this.BTNext_Click);
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "ห้องพักประหยัด",
            "ห้องธรรมดา",
            "ห้องคู่รัก",
            "ห้องครอบครัว"});
            this.CBType.Location = new System.Drawing.Point(241, 225);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 21);
            this.CBType.TabIndex = 8;
            this.CBType.SelectedIndexChanged += new System.EventHandler(this.CBType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ประเภทห้องพัก";
            // 
            // TBTypePrice
            // 
            this.TBTypePrice.Location = new System.Drawing.Point(533, 223);
            this.TBTypePrice.Multiline = true;
            this.TBTypePrice.Name = "TBTypePrice";
            this.TBTypePrice.ReadOnly = true;
            this.TBTypePrice.Size = new System.Drawing.Size(117, 23);
            this.TBTypePrice.TabIndex = 10;
            this.TBTypePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ราคาห้อง";
            // 
            // EX3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBTypePrice);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNext);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBSname);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.label1);
            this.Name = "EX3_2";
            this.Text = "EX3_2";
            this.Load += new System.EventHandler(this.EX1_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBSname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Button BTNext;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBTypePrice;
        private System.Windows.Forms.Label label3;
    }
}