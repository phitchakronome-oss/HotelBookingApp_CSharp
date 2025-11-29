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
    public partial class EX3_3 : Form
    {
        public EX3_3()
        {
            InitializeComponent();
        }

        public string Date , Type, TypePrice;
        
        private void EX1_3_Load(object sender, EventArgs e)
        {
            TBDate.Text = Date;
            TBType.Text = Type;
            TBTypePrice.Text = TypePrice;
        }

        private void Cal()
        {
            int id = 0;
            double Num = 0, Price = 0;
            if (int.TryParse(TBTypePrice.Text, out id))
            {
                Num = Convert.ToDouble(NUDNum.Value);
                Price = id * Num;
                TBPrice.Text = Price.ToString();
            }
            else
            {
                
            }
        }

        private void CBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cal();
        }

        private void NUDNum_ValueChanged(object sender, EventArgs e)
        {
            Cal();
        }

        private void BTNext_Click(object sender, EventArgs e)
        {
            EX3_1.Date = TBDate.Text;
            EX3_1.Type = TBType.Text;
            EX3_1.Num = NUDNum.Value.ToString();
            EX3_1.Price = TBPrice.Text;
            this.Close();
        }

        private void TBDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBType_TextChanged(object sender, EventArgs e)
        {
            Cal();
        }

        private void TBPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
