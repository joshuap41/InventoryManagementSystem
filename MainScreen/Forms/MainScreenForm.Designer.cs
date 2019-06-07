namespace PASoftware1Project
{
    partial class MainScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.PartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.PartsSearchButton = new System.Windows.Forms.Button();
            this.ProductsSearchTextBox = new System.Windows.Forms.TextBox();
            this.ProductsSearchButton = new System.Windows.Forms.Button();
            this.PartsAddButton = new System.Windows.Forms.Button();
            this.ProductsAddButton = new System.Windows.Forms.Button();
            this.PartsDeleteButton = new System.Windows.Forms.Button();
            this.ProductsDeleteButton = new System.Windows.Forms.Button();
            this.PartsModifyButton = new System.Windows.Forms.Button();
            this.ProductsModifyButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 26);
            this.label2.TabIndex = 67;
            this.label2.Text = "Inventory Management System";
            // 
            // PartsSearchTextBox
            // 
            this.PartsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsSearchTextBox.Location = new System.Drawing.Point(354, 144);
            this.PartsSearchTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.PartsSearchTextBox.Name = "PartsSearchTextBox";
            this.PartsSearchTextBox.Size = new System.Drawing.Size(129, 26);
            this.PartsSearchTextBox.TabIndex = 88;
            this.toolTip1.SetToolTip(this.PartsSearchTextBox, "Enter a value to search for.");
            this.PartsSearchTextBox.TextChanged += new System.EventHandler(this.PartsSearchTextBox_TextChanged);
            // 
            // PartsSearchButton
            // 
            this.PartsSearchButton.Location = new System.Drawing.Point(242, 131);
            this.PartsSearchButton.Margin = new System.Windows.Forms.Padding(1);
            this.PartsSearchButton.Name = "PartsSearchButton";
            this.PartsSearchButton.Size = new System.Drawing.Size(91, 44);
            this.PartsSearchButton.TabIndex = 87;
            this.PartsSearchButton.Text = "Search";
            this.toolTip1.SetToolTip(this.PartsSearchButton, "Search for a part.");
            this.PartsSearchButton.UseVisualStyleBackColor = true;
            this.PartsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // ProductsSearchTextBox
            // 
            this.ProductsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsSearchTextBox.Location = new System.Drawing.Point(912, 144);
            this.ProductsSearchTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsSearchTextBox.Name = "ProductsSearchTextBox";
            this.ProductsSearchTextBox.Size = new System.Drawing.Size(129, 26);
            this.ProductsSearchTextBox.TabIndex = 90;
            this.toolTip1.SetToolTip(this.ProductsSearchTextBox, "Enter a value to search for.");
            this.ProductsSearchTextBox.TextChanged += new System.EventHandler(this.ProductsSearchTextBox_TextChanged);
            // 
            // ProductsSearchButton
            // 
            this.ProductsSearchButton.Location = new System.Drawing.Point(792, 131);
            this.ProductsSearchButton.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsSearchButton.Name = "ProductsSearchButton";
            this.ProductsSearchButton.Size = new System.Drawing.Size(91, 44);
            this.ProductsSearchButton.TabIndex = 89;
            this.ProductsSearchButton.Text = "Search";
            this.toolTip1.SetToolTip(this.ProductsSearchButton, "Search for a product.");
            this.ProductsSearchButton.UseVisualStyleBackColor = true;
            this.ProductsSearchButton.Click += new System.EventHandler(this.ProductsSearchButton_Click);
            // 
            // PartsAddButton
            // 
            this.PartsAddButton.Location = new System.Drawing.Point(162, 408);
            this.PartsAddButton.Margin = new System.Windows.Forms.Padding(1);
            this.PartsAddButton.Name = "PartsAddButton";
            this.PartsAddButton.Size = new System.Drawing.Size(91, 44);
            this.PartsAddButton.TabIndex = 91;
            this.PartsAddButton.Text = "Add";
            this.toolTip1.SetToolTip(this.PartsAddButton, "Add a part.");
            this.PartsAddButton.UseVisualStyleBackColor = true;
            this.PartsAddButton.Click += new System.EventHandler(this.PartsAddButton_Click);
            // 
            // ProductsAddButton
            // 
            this.ProductsAddButton.Location = new System.Drawing.Point(732, 408);
            this.ProductsAddButton.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsAddButton.Name = "ProductsAddButton";
            this.ProductsAddButton.Size = new System.Drawing.Size(91, 44);
            this.ProductsAddButton.TabIndex = 92;
            this.ProductsAddButton.Text = "Add";
            this.toolTip1.SetToolTip(this.ProductsAddButton, "Add a product.");
            this.ProductsAddButton.UseVisualStyleBackColor = true;
            this.ProductsAddButton.Click += new System.EventHandler(this.ProductsAddButton_Click);
            // 
            // PartsDeleteButton
            // 
            this.PartsDeleteButton.Location = new System.Drawing.Point(352, 408);
            this.PartsDeleteButton.Margin = new System.Windows.Forms.Padding(1);
            this.PartsDeleteButton.Name = "PartsDeleteButton";
            this.PartsDeleteButton.Size = new System.Drawing.Size(91, 44);
            this.PartsDeleteButton.TabIndex = 93;
            this.PartsDeleteButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.PartsDeleteButton, "Delete a part.");
            this.PartsDeleteButton.UseVisualStyleBackColor = true;
            this.PartsDeleteButton.Click += new System.EventHandler(this.PartsDeleteButton_Click);
            // 
            // ProductsDeleteButton
            // 
            this.ProductsDeleteButton.Location = new System.Drawing.Point(922, 408);
            this.ProductsDeleteButton.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsDeleteButton.Name = "ProductsDeleteButton";
            this.ProductsDeleteButton.Size = new System.Drawing.Size(91, 44);
            this.ProductsDeleteButton.TabIndex = 94;
            this.ProductsDeleteButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.ProductsDeleteButton, "Delete a product");
            this.ProductsDeleteButton.UseVisualStyleBackColor = true;
            this.ProductsDeleteButton.Click += new System.EventHandler(this.ProductsDeleteButton_Click);
            // 
            // PartsModifyButton
            // 
            this.PartsModifyButton.Location = new System.Drawing.Point(258, 408);
            this.PartsModifyButton.Margin = new System.Windows.Forms.Padding(1);
            this.PartsModifyButton.Name = "PartsModifyButton";
            this.PartsModifyButton.Size = new System.Drawing.Size(91, 44);
            this.PartsModifyButton.TabIndex = 95;
            this.PartsModifyButton.Text = "Modify";
            this.toolTip1.SetToolTip(this.PartsModifyButton, "Modify a part.");
            this.PartsModifyButton.UseVisualStyleBackColor = true;
            this.PartsModifyButton.Click += new System.EventHandler(this.PartsModifyButton_Click);
            // 
            // ProductsModifyButton
            // 
            this.ProductsModifyButton.Location = new System.Drawing.Point(828, 408);
            this.ProductsModifyButton.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsModifyButton.Name = "ProductsModifyButton";
            this.ProductsModifyButton.Size = new System.Drawing.Size(91, 44);
            this.ProductsModifyButton.TabIndex = 96;
            this.ProductsModifyButton.Text = "Modify";
            this.toolTip1.SetToolTip(this.ProductsModifyButton, "Modify a product.");
            this.ProductsModifyButton.UseVisualStyleBackColor = true;
            this.ProductsModifyButton.Click += new System.EventHandler(this.ProductsModifyButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(834, 190);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView2.MaximumSize = new System.Drawing.Size(2, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(2, 0);
            this.dataGridView2.TabIndex = 98;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(28, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 99;
            this.label1.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(587, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 100;
            this.label3.Text = "Products";
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(590, 190);
            this.ProductsDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.ProductsDataGridView.MultiSelect = false;
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.RowTemplate.Height = 33;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(446, 190);
            this.ProductsDataGridView.TabIndex = 102;
            this.toolTip1.SetToolTip(this.ProductsDataGridView, "All Products");
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellClick);
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.AllowUserToAddRows = false;
            this.PartsDataGridView.AllowUserToDeleteRows = false;
            this.PartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.Location = new System.Drawing.Point(34, 190);
            this.PartsDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.PartsDataGridView.MultiSelect = false;
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.ReadOnly = true;
            this.PartsDataGridView.RowTemplate.Height = 33;
            this.PartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGridView.Size = new System.Drawing.Size(446, 190);
            this.PartsDataGridView.TabIndex = 103;
            this.toolTip1.SetToolTip(this.PartsDataGridView, "All parts");
            this.PartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(922, 502);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 44);
            this.ExitButton.TabIndex = 104;
            this.ExitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.ExitButton, "Exit this appliction.");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 527);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PartsDataGridView);
            this.Controls.Add(this.PartsAddButton);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ProductsModifyButton);
            this.Controls.Add(this.PartsModifyButton);
            this.Controls.Add(this.ProductsDeleteButton);
            this.Controls.Add(this.PartsDeleteButton);
            this.Controls.Add(this.ProductsAddButton);
            this.Controls.Add(this.ProductsSearchTextBox);
            this.Controls.Add(this.ProductsSearchButton);
            this.Controls.Add(this.PartsSearchTextBox);
            this.Controls.Add(this.PartsSearchButton);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainScreenForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartsSearchTextBox;
        private System.Windows.Forms.Button PartsSearchButton;
        private System.Windows.Forms.TextBox ProductsSearchTextBox;
        private System.Windows.Forms.Button ProductsSearchButton;
        private System.Windows.Forms.Button PartsAddButton;
        private System.Windows.Forms.Button ProductsAddButton;
        private System.Windows.Forms.Button PartsDeleteButton;
        private System.Windows.Forms.Button ProductsDeleteButton;
        private System.Windows.Forms.Button PartsModifyButton;
        private System.Windows.Forms.Button ProductsModifyButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

