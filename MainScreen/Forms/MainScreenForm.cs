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

    public partial class MainScreenForm : Form
    {


        public MainScreenForm() //constructor
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PartsDataGridView.DataSource = Inventory.AllParts;
            PartsDataGridView.ClearSelection();

            ProductsDataGridView.DataSource = Inventory.Products;
            ProductsDataGridView.ClearSelection();
        }

        public void BackToMainScreen()
        {
            MainScreenForm myMainScreenForm = new MainScreenForm();
            this.Hide();
            myMainScreenForm.Show();
        }


        public void PartsSearchButton_Click(object sender, EventArgs e)
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
                            row.Selected = true;
                        }
                    }
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

        private void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsSearchTextBox.Text != "")
                {
                    String searchValue = ProductsSearchTextBox.Text.ToUpper();
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in ProductsDataGridView.Rows)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    //this highlights the row
                    ProductsDataGridView.Rows[rowIndex].Selected = true;
                }
                else
                {
                    MessageBox.Show("Please enter a value to search for.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The product doesn't exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ProductsSearchTextBox.Clear();
        }

        private void ProductsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyPartForm myModifyPartForm = new ModifyPartForm();
                this.Hide();
                myModifyPartForm.Show();
            }
            catch
            {
                MessageBox.Show("Please select a part from the list to modify.", "Main Screen Form");
            }
        }

        private void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please select a part and click Yes to confirm deletion.", "Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inventory.DeletePart(Inventory.CurrentPart);
                BackToMainScreen();
            }
        }

        private void ProductsAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm myAddProductForm = new AddProductForm();
            this.Hide();
            myAddProductForm.Show();
        }

        private void ProductsModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyProductForm myModifyProductForm = new ModifyProductForm();
                this.Hide();
                myModifyProductForm.Show();
            }
            catch
            {
                MessageBox.Show("Please select a product from the list to modify.", "Main Screen Form");
            }
        }

        private void ProductsDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please select a Product and click Yes to confirm deletion.", "Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inventory.Products.RemoveAt(ProductsDataGridView.SelectedRows[0].Index);
                BackToMainScreen();
            }
        }

        private void PartsAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm myAccountForm = new AddPartForm(); //created the object to representing the form that i want to view
            this.Hide();
            myAccountForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Click OK to confirm exit.", "Main Screen Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1
            try
            {
                int a = e.RowIndex; //index within the DataGridView
                int x = (int)PartsDataGridView.Rows[a].Cells[0].Value; //value that we are wanting
                Inventory.CurrentPart = Inventory.LookupPart(x);
                Inventory.CurrentPartIndex = a;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid part.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1
            try
            {
                int b = e.RowIndex;
                int y = (int)ProductsDataGridView.Rows[b].Cells[0].Value;
                Inventory.CurrentProduct = Inventory.LookupProduct(y);
                Inventory.CurrentProductIndex = b;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}