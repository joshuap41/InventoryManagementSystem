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
    public partial class AddProductForm : Form
    {

        Product futureProduct;

        public AddProductForm() //constructor
        {
            InitializeComponent();

            #region resize the form
            int right = this.Controls.Cast<Control>().Max(c => c.Right);
            int bottom = this.Controls.Cast<Control>().Max(c => c.Bottom);

            // leave a little padding, add maybe 10px or 10%?
            int minWidth = right + 60;
            int minHeight = bottom + 60;

            this.Size = new Size(minWidth, minHeight);
            this.MinimumSize = new Size(minWidth, minHeight);
            #endregion


            IdTextBox.Enabled = false;

            futureProduct = new Product("dummy", 50.00, 5, 1, 50);

            PartsDataGridView.DataSource = Inventory.AllParts;
            APDataGridView.DataSource = futureProduct.AssociatedParts;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            APDataGridView.ClearSelection();
            APDataGridView.DataSource = futureProduct.AssociatedParts;
        }

        public void BackToMainScreen()
        {
            MainScreenForm myMainScreenForm = new MainScreenForm();
            this.Hide();
            myMainScreenForm.Show();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvTextBox_TextChanged(object sender, EventArgs e)
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

        private void PartsSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PartsSearchTextBox.Text != "")
                {
                    String searchValue = PartsSearchTextBox.Text.ToUpper();
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in PartsDataGridView.Rows)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    //shows selected row
                    PartsDataGridView.Rows[rowIndex].Selected = true;
                }
                else
                {
                    MessageBox.Show("Please enter a value to search for.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The part doesn't exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PartsSearchTextBox.Clear();
        }

        private void PartsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = PartsDataGridView.CurrentCell.RowIndex;
                Inventory.CurrentPart = Inventory.LookupPart((int)PartsDataGridView.Rows[a].Cells[0].Value);
            }

            catch (Exception)
            {
                MessageBox.Show("Please select a valid part.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentPart != null)
            {
                futureProduct.AddAssociatedPart(Inventory.CurrentPart);

                APDataGridView.DataSource = futureProduct.AssociatedParts;
            }
            else
            {
                MessageBox.Show("Please select a part from the list to modify.", "Main Screen Form");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Click OK to confirm deletion.", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                futureProduct.RemoveAssociatedPart(Inventory.CurrentAssociatedPart);
            }
        }

        private void APDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void APDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = APDataGridView.CurrentCell.RowIndex;

                Inventory.CurrentAssociatedPart = futureProduct.LookupAssociatedPart((int)APDataGridView.Rows[a].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid associated part.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Click OK to confirm cancel.", "Add Product Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BackToMainScreen();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text == "" || PriceCostTextBox.Text == "" || InvTextBox.Text == "" || MaxTextBox.Text == "" || MinTextBox.Text == "")
                {
                    MessageBox.Show("Please enter values for all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(MinTextBox.Text) > Convert.ToInt32(MaxTextBox.Text))
                {
                    MessageBox.Show("Your Min cannot exceed your Max", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(InvTextBox.Text) > Convert.ToInt32(MaxTextBox.Text))
                {
                    MessageBox.Show("Your Inv cannot exceed your Max", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    futureProduct.Name = NameTextBox.Text;
                    futureProduct.Price = Convert.ToDouble(PriceCostTextBox.Text);
                    futureProduct.Inv = Convert.ToInt32(InvTextBox.Text);
                    futureProduct.Min = Convert.ToInt32(MinTextBox.Text);
                    futureProduct.Max = Convert.ToInt32(MaxTextBox.Text);


                    Inventory.AddProduct(futureProduct);

                    BackToMainScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region----------KeyPress to validate user input----------

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



        #endregion
    }
}
