using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
       
        enum enSize
        {
            small=10,
            medium=20,
            large=30
        }

        enum enThikness
        {
            thin=10,
            thick=20
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_small.Checked)
                lb_size.Text="Small";
            FinalCalculate();
        }

        private void rd_medium_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_medium.Checked)
                lb_size.Text = "Medium";
            FinalCalculate();
        }

        private void rd_large_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_large.Checked)
                lb_size.Text = "Large";
            FinalCalculate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_thin.Checked)
                lb_crust.Text = "Thin Crust";
            FinalCalculate();
        }

        private void rd_thick_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_thick.Checked)
                lb_crust.Text = "Thick Crust";
            FinalCalculate();
        }

        private void rd_inouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_inouse.Checked)
                lb_eat.Text = "In House";
        }

        private void rd_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_takeaway.Checked)
                lb_eat.Text = "Take Away";
        }

        private void chChees_CheckedChanged(object sender, EventArgs e)
        {
            FinalCalculate();
        }

        private void FinalCalculate()
        {
            int total = 0;
            string toppings = "";

            if (rd_small.Checked)
                total += (int) enSize.small;

            if (rd_medium.Checked)
                total += (int)enSize.medium;

            if (rd_large.Checked)
                total += (int)enSize.large;

            if (rd_thin.Checked)
                total += (int) enThikness.thin;

            if (rd_thick.Checked)
                total += (int)enThikness.thick;

            if (chChees.Checked)
            {
                total += 5;
                toppings += "Chees";
            }
               

            if(chMush.Checked)
            {
                total += 5;
                toppings += "Mush,";
            }

            if (chOlives.Checked)
            {
                total += 5;
                toppings += "Olives,";
            }

            if (chPapers.Checked)
            {
                total += 5;
                toppings += "Papers,";
            }

            if (chTomatos.Checked)
            {
                total += 5;
                toppings += "Tomatos,";
            }

            if (chOnion.Checked)
            {
                total += 5;
                toppings += "Onion,";
            }


            lb_total.Text = "$"+total.ToString();

            if (toppings.StartsWith(","))
            {
                toppings = toppings.Substring(1, toppings.Length - 1).Trim();
            }

            if (toppings == "")
                toppings = "No Toppings";

            lb_toppings.Text = toppings;

            
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            FinalCalculate();
        }

        private void chMush_CheckedChanged(object sender, EventArgs e)
        {
            FinalCalculate();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            FinalCalculate();
        }

        private void chTomatos_CheckedChanged(object sender, EventArgs e)
        {
            FinalCalculate();
        }

        private void chPapers_CheckedChanged(object sender, EventArgs e)
        {
            FinalCalculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rd_medium.Checked = true;

            //reset Toppings.
            chChees.Checked = false;
            chOnion.Checked = false;
            chMush.Checked = false;
            chOlives.Checked = false;
            chTomatos.Checked = false;
            chPapers.Checked = false;

            //reset CrustType
            rd_thin.Checked = true;

            //reset Where to Eat
            rd_inouse.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;
        }
    }
}
