using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        IMyCalculator Calculator;

        public Form1()
        {
            InitializeComponent();
            Calculator = new Calculator();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if(validatinput())
            {
                int sum = Calculator.plus((int)txtnumber1.Value ,(int)txtnumber2.Value);
                MessageBox.Show("جمع مساوی :" + sum);

            }

        }
        bool validatinput()
        {
            bool isvalidat = true;
            if (txtnumber1.Value == 0)
            {
                MessageBox.Show("عدد صفر وارد نکنید");
                 isvalidat = false;
            }
            else
            {
                if(txtnumber2.Value==0)
                {
                    MessageBox.Show("عدد صفر وارد نکنید");
                    isvalidat = false;

                }
            }
            return isvalidat;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (validatinput())
            {
                int minus = Calculator.minus((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("تفریق مساوی :" + minus);

            }
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            if (validatinput())
            {
                int multiple = Calculator.multiple((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("ضرب مساوی :" + multiple);
            }
        }

        private void btndivid_Click(object sender, EventArgs e)
        {
            int divid = Calculator.divide((int)txtnumber1.Value, (int)txtnumber2.Value);
            MessageBox.Show("تقسیم مساوی :" + divid);
        }

    }
}
