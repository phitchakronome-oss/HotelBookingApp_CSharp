namespace EX1_1
{
    partial class EX3_3
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
            this.TBDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.BTNext = new System.Windows.Forms.Button();
            this.TBType = new System.Windows.Forms.TextBox();
            this.TBTypePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "วันที่จอง";
            // 
            // TBDate
            // 
            this.TBDate.Location = new System.Drawing.Point(213, 56);
            this.TBDate.Name = "TBDate";
            this.TBDate.ReadOnly = true;
            this.TBDate.Size = new System.Drawing.Size(132, 20);
            this.TBDate.TabIndex = 3;
            this.TBDate.TextChanged += new System.EventHandler(this.TBDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ประเภทห้องพัก";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "จำนวนวันที่พัก";
            // 
            // NUDNum
            // 
            this.NUDNum.Location = new System.Drawing.Point(213, 175);
            this.NUDNum.Name = "NUDNum";
            this.NUDNum.Size = new System.Drawing.Size(120, 20);
            this.NUDNum.TabIndex = 7;
            this.NUDNum.ValueChanged += new System.EventHandler(this.NUDNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ค่าใช้จ่าย";
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(213, 238);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.ReadOnly = true;
            this.TBPrice.Size = new System.Drawing.Size(169, 20);
            this.TBPrice.TabIndex = 9;
            this.TBPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBPrice.TextChanged += new System.EventHandler(this.TBPrice_TextChanged);
            // 
            // BTNext
            // 
            this.BTNext.Location = new System.Drawing.Point(233, 318);
            this.BTNext.Name = "BTNext";
            this.BTNext.Size = new System.Drawing.Size(112, 36);
            this.BTNext.TabIndex = 10;
            this.BTNext.Text = "ยืนยันการจอง";
            this.BTNext.UseVisualStyleBackColor = true;
            this.BTNext.Click += new System.EventHandler(this.BTNext_Click);
            // 
            // TBType
            // 
            this.TBType.Location = new System.Drawing.Point(213, 116);
            this.TBType.Name = "TBType";
            this.TBType.ReadOnly = true;
            this.TBType.Size = new System.Drawing.Size(132, 20);
            this.TBType.TabIndex = 11;
            this.TBType.TextChanged += new System.EventHandler(this.TBType_TextChanged);
            // 
            // TBTypePrice
            // 
            this.TBTypePrice.Location = new System.Drawing.Point(466, 116);
            this.TBTypePrice.Name = "TBTypePrice";
            this.TBTypePrice.ReadOnly = true;
            this.TBTypePrice.Size = new System.Drawing.Size(132, 20);
            this.TBTypePrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ราคาห้อง";
            // 
            // EX3_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 399);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBTypePrice);
            this.Controls.Add(this.TBType);
            this.Controls.Add(this.BTNext);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUDNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBDate);
            this.Controls.Add(this.label1);
            this.Name = "EX3_3";
            this.Text = "EX3_3";
            this.Load += new System.EventHandler(this.EX1_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Button BTNext;
        private System.Windows.Forms.TextBox TBType;
        private System.Windows.Forms.TextBox TBTypePrice;
        private System.Windows.Forms.Label label5;
    }
}