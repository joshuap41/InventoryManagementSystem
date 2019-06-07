using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASoftware1Project
{
    public partial class ModifyPartForm : Form
    {
        #region populates the textboxes
        private void FillOut(Outsourced P)
        {
            SourceTextBox.Text = P.CompanyName;
        }

        private void FillIn(InHouse P)
        {
            SourceTextBox.Text = P.MachineID.ToString();
        }
        #endregion
        
        #region allows for save
        private void FillO(Outsourced P)
        {
            P.CompanyName = SourceTextBox.Text;
        }

        private void FillI(InHouse P)
        {
            P.MachineID = Convert.ToInt32(SourceTextBox.Text);
        }
        #endregion
        

        public ModifyPartForm()
        {
            InitializeComponent();

            #region resize the form
            int right = this.Controls.Cast<Control>().Max(c => c.Right);
            int bottom = this.Controls.Cast<Control>().Max(c => c.Bottom);

            // leave a little padding
            int minWidth = right + 60;
            int minHeight = bottom + 60;

            this.Size = new Size(minWidth, minHeight);
            this.MinimumSize = new Size(minWidth, minHeight);
            #endregion

            IDTextBox.Enabled = false;

            //4
            IDTextBox.Text = Inventory.CurrentPart.PartID.ToString();
            NameTextBox.Text = Inventory.CurrentPart.Name;
            InventoryTextBox.Text = Inventory.CurrentPart.InStock.ToString();
            PriceCostTextBox.Text = Inventory.CurrentPart.Price.ToString();
            MaxTextBox.Text = Inventory.CurrentPart.Max.ToString();
            MinTextBox.Text = Inventory.CurrentPart.Min.ToString();

            //change the radio button to reflect the type of part that was chosen.
            if (Inventory.CurrentPart.GetType() == typeof(Outsourced))
            {
                OutsourcedRadioButton.Checked = true;
                IsOutsourced = true; //Outsourced
                FillOut((Outsourced)Inventory.CurrentPart);
            }
            else
            {
                InHouseRadioButton.Checked = true;
                IsOutsourced = false; //InHouse
                FillIn((InHouse)Inventory.CurrentPart);
            }
        }

        public bool IsOutsourced;


        public void BackToMainScreen()
        {
            MainScreenForm myMainScreenForm = new MainScreenForm();
            this.Hide();
            myMainScreenForm.Show();
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CompanyMachineToggle.Text = "Machine ID";
            IsOutsourced = false;
            SourceTextBox.Clear();
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CompanyMachineToggle.Text = "Company Name";
            IsOutsourced = true;
            SourceTextBox.Clear();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Click Yes to confirm cancel.", "Modify Part Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BackToMainScreen();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text == "" || PriceCostTextBox.Text == "" || InventoryTextBox.Text == "" || MaxTextBox.Text == "" || MinTextBox.Text == "" || SourceTextBox.Text == "")
                {
                    MessageBox.Show("Please enter values for all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(MinTextBox.Text) > Convert.ToInt32(MaxTextBox.Text))
                {
                    MessageBox.Show("Your Min cannot exceed your Max", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(InventoryTextBox.Text) > Convert.ToInt32(MaxTextBox.Text))
                {
                    MessageBox.Show("Your Inv cannot exceed your Max", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //5 takes the modified part and saves it to the same index
                    Inventory.CurrentPart.PartID = Convert.ToInt32(IDTextBox.Text);
                    Inventory.CurrentPart.Name = NameTextBox.Text;
                    Inventory.CurrentPart.InStock = Convert.ToInt32(InventoryTextBox.Text);
                    Inventory.CurrentPart.Price = Convert.ToDouble(PriceCostTextBox.Text);
                    Inventory.CurrentPart.Max = Convert.ToInt32(MaxTextBox.Text);
                    Inventory.CurrentPart.Min = Convert.ToInt32(MinTextBox.Text);
                    
                    if (Inventory.CurrentPart.GetType() == typeof(Outsourced))
                    {
                        if (!IsOutsourced)
                        {
                            var tempPart = new InHouse(Inventory.CurrentPart.PartID, Inventory.CurrentPart.Name, Inventory.CurrentPart.Price, Inventory.CurrentPart.InStock, Inventory.CurrentPart.Min, Inventory.CurrentPart.Max, 0); //make a method for the mID to input into the constructor
                            FillI(tempPart);
                            Inventory.UpdatePart(Inventory.CurrentPartIndex, tempPart);
                        }
                        else
                        {
                            FillO((Outsourced)Inventory.CurrentPart);
                            Inventory.UpdatePart(Inventory.CurrentPartIndex, Inventory.CurrentPart);
                        }
                    }
                    else
                    {
                        if (IsOutsourced)
                        {
                            var tempPart = new Outsourced(Inventory.CurrentPart.PartID, Inventory.CurrentPart.Name, Inventory.CurrentPart.Price, Inventory.CurrentPart.InStock, Inventory.CurrentPart.Min, Inventory.CurrentPart.Max, "dummy");
                            FillO(tempPart);
                            Inventory.UpdatePart(Inventory.CurrentPartIndex, tempPart);
                        }
                        else
                        {
                            FillI((InHouse)Inventory.CurrentPart);
                            Inventory.UpdatePart(Inventory.CurrentPartIndex, Inventory.CurrentPart);
                        }
                    }
                    BackToMainScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ----------KeyPress to validate user input----------

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Please enter a Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void InvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //number only entry
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void PriceCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && PriceCostTextBox.Text.Contains("."))
            {
                // Stop more than one dot Char
                e.Handled = true;
                MessageBox.Show("Price/Cost can only contain one decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (e.KeyChar == '.' && PriceCostTextBox.Text.Length == 0)
            {
                // Stop first char as a dot input
                e.Handled = true;
                MessageBox.Show("Please enter only one decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Stop allow other than digit and control
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void MaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void MinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void SourceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (InHouseRadioButton.Checked)
                {
                    if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        SourceTextBox.Clear();
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
                    {
                        e.Handled = true;
                        base.OnKeyPress(e);
                        MessageBox.Show("Please enter a Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        SourceTextBox.Clear();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect datatype for part source.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion
    }
}
