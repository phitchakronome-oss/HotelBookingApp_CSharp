using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX1_1
{
    public partial class EX3_2 : Form
    {
        public EX3_2()
        {
            InitializeComponent();
        }


        public string Sname ,TypePrice;


        private void EX1_2_Load(object sender, EventArgs e)
        {
            LBName.Text = Name;
            LBSname.Text = Sname;

        }

        private void LBName_Click(object sender, EventArgs e)
        {

        }

        private void CBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cal();
        }

        private void Cal()
        {
            int id;
            double Price = 0;
            id = CBType.SelectedIndex;
            switch (id)
            {
                case 0:
                    Price = 400 ; break;
                case 1:
                    Price = 800 ; break;
                case 2:
                    Price = 1200 ; break;
                case 3:
                    Price = 2000 ; break;
            }
            TBTypePrice.Text = Price.ToString();
        }

        private void BTNext_Click(object sender, EventArgs e)
        {
            DateTime Date;
            string DateString;
            Date = DTP1.Value;
            DateString = Date.ToShortDateString();
            EX3_3 F3 = new EX3_3();
            F3.Date = DateString;
            F3.Type = CBType.SelectedItem.ToString();
            F3.TypePrice = TBTypePrice.Text;
            this.Close();
            F3.ShowDialog();
        }
    }
}
