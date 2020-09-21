using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swan
{
    public delegate void InputReadyForSave(object sender, EventArgs e, bool ready);
    public partial class FormAdd : Form
    {
        public event InputReadyForSave rdy;
        private bool firstNameFilled = false;
        private bool lastNameFilled = false;
        private bool homeNumberFilled = false;
        private bool mobileNumberFilled = false;
        private bool emergencyContactFilled = false;
        private bool emergencyNumberFilled = false;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void checkToActivateBtnOk(object sender, EventArgs e)
        {
            if (firstNameFilled && lastNameFilled && (homeNumberFilled || mobileNumberFilled) && emergencyContactFilled && emergencyNumberFilled && rdy != null)
            {
                rdy(sender, e, true);
            }
            else
            {
                rdy(sender, e, false);
            }
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text))
            {
                firstNameFilled = false;
            }
            else
            {
                firstNameFilled = true;
            }
            checkToActivateBtnOk(sender, e);
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameBox.Text))
            {
                lastNameFilled = false;
            }
            else
            {
                lastNameFilled = true;
            }
            checkToActivateBtnOk(sender, e);
        }

        private void homeNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(homeNumberBox.Text))
            {
                homeNumberFilled = false;
            }
            else
            {
                homeNumberFilled = true;
            }
            checkToActivateBtnOk(sender, e);
        }

        private void mobileNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mobileNumberBox.Text))
            {
                mobileNumberFilled = false;
            }
            else
            {
                mobileNumberFilled = true;
            }
            checkToActivateBtnOk(sender, e);
        }

        private void emergencyContactBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emergencyContactBox.Text))
            {
                emergencyContactFilled = false;
            }
            else
            {
                emergencyContactFilled = true;
            }
            checkToActivateBtnOk(sender, e);
        }

        private void emergencyNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emergencyNumberBox.Text))
            {
                emergencyNumberFilled = false;
            }
            else
            {
                emergencyNumberFilled = true;
            }
            checkToActivateBtnOk(sender, e);
        }

        public void clearInput()
        {
            foreach (TextBox txt in this.Controls[1].Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
        }

        public void showErrorMessage(string msg)
        {
            addErrorLabel.Text = msg;
        }
    }
}
