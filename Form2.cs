using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rdoSmall.Checked)
                return Convert.ToSingle(rdoSmall.Tag);

            else if (rdoMedium.Checked)
                return Convert.ToSingle(rdoMedium.Tag);

            else
                return Convert.ToSingle(rdoLarge.Tag);
        }

        float GetCrustTypePrice()
        {
            if (rdoThick.Checked)
                return Convert.ToSingle(rdoThick.Tag);

            else
                return Convert.ToSingle(rdoThin.Tag);
        }

        float GetWhereToEatPrice()
        {
            if (rdoEatIn.Checked)
                return Convert.ToSingle(rdoEatIn.Tag);

            else
                return Convert.ToSingle(rdoTakeaway.Tag);
        }

        float GetTopingPrice()
        {
            float TotalToppingPrice = 0;

            if (chkExtreaCheese.Checked)
                TotalToppingPrice += Convert.ToSingle(chkExtreaCheese.Tag);

            if (chkMashrom.Checked)
                TotalToppingPrice += Convert.ToSingle(chkMashrom.Tag);

             if (chkolives.Checked)
                TotalToppingPrice += Convert.ToSingle(chkolives.Tag);

             if (chkOnion.Checked)
                TotalToppingPrice += Convert.ToSingle(chkOnion.Tag);

             if (chkPickledCucumber.Checked)
                TotalToppingPrice += Convert.ToSingle(chkPickledCucumber.Tag);

             if (chkTomatoos.Checked)
                TotalToppingPrice += Convert.ToSingle(chkTomatoos.Tag);

             return TotalToppingPrice;
        }

        float CalculateTotalPrice()
        {
            return GetCrustTypePrice() + GetWhereToEatPrice() + GetSelectedSizePrice() + GetTopingPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rdoSmall.Checked)
                lblSize.Text = "Small";

            else if (rdoMedium.Checked)
                lblSize.Text = "Medium";

            else
                lblSize.Text = "Large";
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rdoThin.Checked)
                lblCrustType.Text = "Thin Crust";

            else
                lblCrustType.Text = "Thick Crust";
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rdoEatIn.Checked)
                lblWhereToeat.Text = "Eat In";

            else
                lblWhereToeat.Text = "Takeaway";
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtreaCheese.Checked)
                sToppings = "Extra Cheese";

            if (chkMashrom.Checked)
                sToppings += ", Mashrom";

            if (chkolives.Checked)
                sToppings += ", Olives";

            if (chkOnion.Checked)
                sToppings += ", Onion";

            if (chkPickledCucumber.Checked)
                sToppings += ", Pickled Cucumber";

            if (chkTomatoos.Checked)
                sToppings += ", Tomatoos";

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1);
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblTopping.Text = sToppings;
        }

        void EnableGroups()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbTopping.Enabled = true;
            
        }

        void ResetRadioButtons()
        {
            rdoSmall.Checked = true;
            rdoThin.Checked = true;
            rdoEatIn.Checked = true;
        }

        void ResetToppings()
        {
            chkExtreaCheese.Checked = false;
            chkMashrom.Checked = false;
            chkolives.Checked = false;
            chkOnion.Checked = false;
            chkPickledCucumber.Checked = false;
            chkTomatoos.Checked = false;
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm order?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order has been ordered successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderNow.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbTopping.Enabled = false;
                //.Enabled = false;
            }
        }

        private void btnReserOrder_Click(object sender, EventArgs e)
        {
            btnOrderNow.Enabled = true;
            EnableGroups();
            ResetRadioButtons();
            ResetToppings();
        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdoTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtreaCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMashrom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkolives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkPickledCucumber_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ResetRadioButtons();
            ResetToppings();
            UpdateTotalPrice();
        }

        private void gbWhereToEat_Enter(object sender, EventArgs e)
        {

        }
    }

}
