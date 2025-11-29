namespace EX1_1
{
    partial class EX3_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSname = new System.Windows.Forms.TextBox();
            this.BTNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "นามสกุล";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(151, 146);
            this.TBName.Multiline = true;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(205, 20);
            this.TBName.TabIndex = 2;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            // 
            // TBSname
            // 
            this.TBSname.Location = new System.Drawing.Point(437, 146);
            this.TBSname.Multiline = true;
            this.TBSname.Name = "TBSname";
            this.TBSname.Size = new System.Drawing.Size(205, 20);
            this.TBSname.TabIndex = 3;
            this.TBSname.TextChanged += new System.EventHandler(this.TBSname_TextChanged);
            // 
            // BTNext
            // 
            this.BTNext.Location = new System.Drawing.Point(305, 223);
            this.BTNext.Name = "BTNext";
            this.BTNext.Size = new System.Drawing.Size(126, 37);
            this.BTNext.TabIndex = 6;
            this.BTNext.Text = "จองที่พัก";
            this.BTNext.UseVisualStyleBackColor = true;
            this.BTNext.Click += new System.EventHandler(this.BTNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hotel Lobby";
            // 
            // EX3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNext);
            this.Controls.Add(this.TBSname);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EX3_1";
            this.Text = "EX3_1";
            this.Load += new System.EventHandler(this.EX3_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSname;
        private System.Windows.Forms.Button BTNext;
        private System.Windows.Forms.Label label3;
    }
}

