using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Pizza
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 2).ToString();
                labAnsSize.Text = "Small";
            }
            else
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 2).ToString();
                labAnsSize.Text = "";
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 4).ToString();
                labAnsSize.Text = "Medium";
            }
            else
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 4).ToString();
                labAnsSize.Text = "";
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 6).ToString();
                labAnsSize.Text = "Large";
            }
            else
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 6).ToString();
                labAnsSize.Text = "";
            }
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinCrust.Checked)
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
                labAnsCrustType.Text = "Thin";
            }
            else
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
                labAnsCrustType.Text = "";
            }
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            labAnsCrustType.Text = "Think";
            if (rbThinkCrust.Checked)
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 2).ToString();
                labAnsCrustType.Text = "Think";
            }
            else
            {
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 2).ToString();
                labAnsCrustType.Text = "";
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                labAnsWhereToEat.Text = "In";
            }
            else 
            {
                labAnsWhereToEat.Text = "";
            }
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatOut.Checked)
            {
                labAnsWhereToEat.Text = "Out";
            }
            else
            {
                labAnsWhereToEat.Text = "";
            }
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            string Topic = "Extra Chees,";
            
            if (chkExtraChees.Checked)
            {
                labAnsToppings.Text += Topic ;
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
            }
            else
            {
                labAnsToppings.Text = labAnsToppings.Text.Replace(Topic,"");
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
            }
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            string Topic = "Mushroom,";
            if (chkMushroom.Checked)
            {
                labAnsToppings.Text += Topic;
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
            }
            else
            {
                labAnsToppings.Text = labAnsToppings.Text.Replace(Topic, "");
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
            }
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            string Topic = "Tomatoes,";
            if (chkTomatoes.Checked)
            {
                labAnsToppings.Text += Topic;
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
            }
            else
            {
                labAnsToppings.Text = labAnsToppings.Text.Replace(Topic, "");
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
            }
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            string Topic = "Onion,";
            if (chkOnion.Checked)
            {
                labAnsToppings.Text += Topic;
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
            }
            else
            {
                labAnsToppings.Text = labAnsToppings.Text.Replace(Topic, "");
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            string Topic = "Olives,";
            if (chkOlives.Checked)
            {
                labAnsToppings.Text += Topic;
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
            }
            else
            {
                labAnsToppings.Text = labAnsToppings.Text.Replace(Topic, "");
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
            }
        }

        private void chkCorn_CheckedChanged(object sender, EventArgs e)
        {
            string Topic = "Corn,";
            if (chkCorn.Checked)
            {
                labAnsToppings.Text += Topic;
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) + 1).ToString();
            }
            else
            {
                labAnsToppings.Text = labAnsToppings.Text.Replace(Topic, "");
                labAnsPrice.Text = (Convert.ToInt32(labAnsPrice.Text) - 1).ToString();
            }
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
            rbLarge.Checked = false;
            rbMedium.Checked = false;
            rbEatIn.Checked = false;
            rbEatOut.Checked = false;
            rbThinCrust.Checked = false;
            rbThinkCrust.Checked = false;
            chkExtraChees.Checked = false;
            chkCorn.Checked = false;
            chkMushroom.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbOrderSummary.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;
            btnOrderPizza.Enabled = true;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if((rbSmall.Checked == false && rbMedium.Checked==false && rbLarge.Checked == false)|| (rbThinCrust.Checked == false && rbThinkCrust.Checked == false) || (rbEatIn.Checked == false && rbEatOut.Checked == false))
            {
                MessageBox.Show("Please Complete your order before send it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (MessageBox.Show("Are you sure ?", "Confirm" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbOrderSummary.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbToppings  .Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }


        private void labAnsPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
