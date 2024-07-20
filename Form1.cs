using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double getGropBoxPrice(System.Windows.Forms.GroupBox grBox)
        {

            double result = 0;

            foreach (Control control in grBox.Controls)
            {
                if (control is System.Windows.Forms.RadioButton)
                {
                    System.Windows.Forms.RadioButton radioButton = control as System.Windows.Forms.RadioButton;
                    if (radioButton.Checked)
                    {
                        return double.Parse(radioButton.Tag.ToString());
                    }
                }

                else if (control is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox checkBoxButton = control as System.Windows.Forms.CheckBox;
                    if (checkBoxButton.Checked)
                    {
                        result += double.Parse(checkBoxButton.Tag.ToString());
                    }
                }
            }

            return result;

        }

        private double getFinalTotlaPrice()
        {
            return this.getGropBoxPrice(gbSize) +
                    this.getGropBoxPrice(gbCrust) +
                    this.getGropBoxPrice(gbEatPlace) +
                    this.getGropBoxPrice(gbTopping);
        }

        private string getFormattingTotalPrice()
        {
            return "$" + this.getFinalTotlaPrice();
        }

        private void showTotalPrice()
        {
            this.changeLableValue(lbTotalPriceValue, this.getFormattingTotalPrice());

        }

        private void changeLableValue(System.Windows.Forms.Label targetLable, string newLableValue)
        {
            targetLable.Text = newLableValue;
        }

        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {

            this.changeOption(sender, lbSizeSummaryValue);
        }

        private void rbCrust_CheckedChanged(object sender, EventArgs e)
        {

            this.changeOption(sender, lbSummaryCrustValue);
        }

        private void rbEatPlace_CheckedChanged(object sender, EventArgs e)
        {

            this.changeOption(sender, lbSummaryEatPlaceValue);
        }

        private void cbTopping_CheckedChanged(object sender, EventArgs e)
        {
            this.changeOption(sender, lbSummaryCrustValue);
        }

        private void changeOption(object sender, System.Windows.Forms.Label targetLable)
        {
            System.Type type = sender.GetType();


            if (type.Name == "RadioButton")
            {
                System.Windows.Forms.RadioButton checkedButton = sender as System.Windows.Forms.RadioButton;
                this.changeLableValue(targetLable, checkedButton.Text);

            }
            else if (type.Name == "CheckBox")
            {
                System.Windows.Forms.CheckBox checkedButton = sender as System.Windows.Forms.CheckBox;

                string toppingsShowText = getAllCheckedToppings();

                this.changeLableValue(targetLable, toppingsShowText);


            }




            this.showTotalPrice();
        }

        private string getAllCheckedToppings()
        {
            string resutl = "";

            foreach (Control control in gbTopping.Controls)
            {
                System.Windows.Forms.CheckBox chBox = control as System.Windows.Forms.CheckBox;
                if (chBox.Checked)
                {
                    resutl += chBox.Text + ",";

                }
            }

            return resutl;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order Placed Successfully", "Pizza Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableOptions();
        }

        private void DisableOptions()
        {
            gbSize.Enabled = false;
            gbEatPlace.Enabled = false;
            gbTopping.Enabled = false;
            gbCrust.Enabled = false;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ///enable groups
            gbSize.Enabled = true;
            gbEatPlace.Enabled = true;
            gbTopping.Enabled = true;
            gbCrust.Enabled = true;
            /// default buttons
            
            rbCrustThin.Checked = true;
            rbSizeSmall.Checked = true;
            rbEatPlaceIn.Checked = true;

            foreach (Control control in gbTopping.Controls)
            {
                System.Windows.Forms.CheckBox checkBox = control as System.Windows.Forms.CheckBox;
                checkBox.Checked = (checkBox.Name == cbToppingChees.Name);
            }

        }

    }
}
