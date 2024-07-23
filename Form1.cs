using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectNew
{
    public partial class Pizza4You : Form
    {
        public Pizza4You()
        {
            InitializeComponent();
        }

        private void rb_size_changed(object sender, EventArgs e)
        {

            changeOption(sender, summerySize);
        }
        private void changeOption(object sender, Label TargetLabel) {

            System.Type type = sender.GetType();
            if (type.Name == "RadioButton")
            {
                RadioButton radioButton = (RadioButton)sender;
                this.changeLabel(radioButton.Text, TargetLabel);

            }else if (type.Name == "CheckBox")
            {
                string CheckedToppings = getAllCheckedToppings();
                this.changeLabel(CheckedToppings,TargetLabel);
            }

            this.showTotalPrice();
        }
        private string getFormattedTotalPrice()
        {

            return "$"+ getFinalTotalPrice();
        }
        private double getFinalTotalPrice() {

            return this.getGropBoxPrice(gbSize) +
                   this.getGropBoxPrice(gbCrust) +
                   this.getGropBoxPrice(gbEat) +
                   this.getGropBoxPrice(gbToppings);
        }
        private double getGropBoxPrice(GroupBox GroupBox)
        {
            double result = 0;

            foreach(Control control in GroupBox.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton radio = (RadioButton)control;
                    if (radio.Checked)
                    {
                        return Convert.ToDouble(radio.Tag);
                    }
                }
                else if (control is CheckBox)
                {
                    CheckBox CheckBox = (CheckBox)control;
                    if (CheckBox.Checked)
                    {
                        result += Convert.ToDouble(CheckBox.Tag);

                    }
                }
            }
            return result;
        }
        private void showTotalPrice()
        {
            this.changeLabel(this.getFormattedTotalPrice(),summeryTotal);
        }
        private string getAllCheckedToppings()
        {
            string result = "";
            foreach (Control control in gbToppings.Controls)
            {
                CheckBox checkBox = (CheckBox)control;
                if (checkBox.Checked)
                {

                    result += checkBox.Text + ",";

                }
                
            }
            return result;
        }
        private void changeLabel(string newLabel, Label TargetLabel) {

            TargetLabel.Text = newLabel;
        }

        private void rb_crust_changed(object sender, EventArgs e)
        {
            changeOption(sender, summeryCrust);
        }

        private void rb_eat_changed(object sender, EventArgs e)
        {
            changeOption(sender, summeryEat);
        }

        private void cbTopping_CheckedChanged(object sender, EventArgs e)
        {
            changeOption(sender, summeryToppings);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            DisableGroups(false);

            rbThin.Checked = true;
            rbMedium.Checked = true;
            rbInhouse.Checked = true;

            foreach (Control control in gbToppings.Controls)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Checked = checkBox.Name == cbChees.Name;
               
            }

        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Placed Successfully", "Pizza Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableGroups(true);
        }

        private void DisableGroups(bool flag)
        {
            if (flag)
            {
                gbSize.Enabled = false;
                gbEat.Enabled = false;
                gbToppings.Enabled = false;
                gbCrust.Enabled = false;
                return;
            }

            gbSize.Enabled = true;
            gbEat.Enabled = true;
            gbToppings.Enabled = true;
            gbCrust.Enabled = true;
        }
    }
}
