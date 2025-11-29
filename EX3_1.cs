using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX1_1
{
    public partial class EX3_1 : Form
    {
        public EX3_1()
        {
            InitializeComponent();
        }

        public static string Date, Type, Num, Price;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBSex1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBSname_TextChanged(object sender, EventArgs e)
        {

        }

        private void EX3_1_Load(object sender, EventArgs e)
        {

        }

        private void RBSex2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNext_Click(object sender, EventArgs e)
        {
            EX3_2 F2 = new EX3_2();
            F2.Name = TBName.Text;
            F2.Sname = TBSname.Text;
            F2.ShowDialog();
            string FullName = TBName.Text + " " + TBSname.Text;
            MessageBox.Show("ชื่อ - นามสกุล : " + FullName + "\n"
                + "วันที่จอง : " + Date + "\n"
                + "ประเภทห้องพัก : " + Type + "\n"
                + "จำนวนวันที่พัก : " + Num + "\n"
                + "ราคาสุทธิ์ :" + Price + "\n", "สรุปการจอง");
        }
    }
}
