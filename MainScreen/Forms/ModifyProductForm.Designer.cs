namespace PASoftware1Project
{
    partial class ModifyProductForm
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
            this.PartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartsSearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceCostTextBox = new System.Windows.Forms.TextBox();
            this.InvTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.ModifyProduct = new System.Windows.Forms.Label();
            this.AssociatedParts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AssociatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsSearchTextBox
            // 
            this.PartsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsSearchTextBox.Location = new System.Drawing.Point(1376, 113);
            this.PartsSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PartsSearchTextBox.Name = "PartsSearchTextBox";
            this.PartsSearchTextBox.Size = new System.Drawing.Size(276, 44);
            this.PartsSearchTextBox.TabIndex = 107;
            this.toolTip1.SetToolTip(this.PartsSearchTextBox, "Enter a value to search for.");
            this.PartsSearchTextBox.TextChanged += new System.EventHandler(this.PartsSearchTextBox_TextChanged);
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.AllowUserToAddRows = false;
            this.PartsDataGridView.AllowUserToDeleteRows = false;
            this.PartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.Location = new System.Drawing.Point(938, 240);
            this.PartsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.PartsDataGridView.MultiSelect = false;
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.ReadOnly = true;
            this.PartsDataGridView.RowTemplate.Height = 33;
            this.PartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataGridView.Size = new System.Drawing.Size(996, 256);
            this.PartsDataGridView.TabIndex = 106;
            this.toolTip1.SetToolTip(this.PartsDataGridView, "All parts.");
            this.PartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellClick);
            // 
            // PartsSearchButton
            // 
            this.PartsSearchButton.Location = new System.Drawing.Point(1136, 85);
            this.PartsSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.PartsSearchButton.Name = "PartsSearchButton";
            this.PartsSearchButton.Size = new System.Drawing.Size(200, 88);
            this.PartsSearchButton.TabIndex = 104;
            this.PartsSearchButton.Text = "Search";
            this.toolTip1.SetToolTip(this.PartsSearchButton, "Search for a part.");
            this.PartsSearchButton.UseVisualStyleBackColor = true;
            this.PartsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1736, 504);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 88);
            this.AddButton.TabIndex = 103;
            this.AddButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddButton, "Add a part.");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1736, 983);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 88);
            this.DeleteButton.TabIndex = 102;
            this.DeleteButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DeleteButton, "Delete a part");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(544, 810);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 37);
            this.label10.TabIndex = 101;
            this.label10.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 810);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 37);
            this.label9.TabIndex = 100;
            this.label9.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 656);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 37);
            this.label8.TabIndex = 99;
            this.label8.Text = "Price/Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 525);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 37);
            this.label6.TabIndex = 98;
            this.label6.Text = "Inv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 37);
            this.label5.TabIndex = 97;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 37);
            this.label4.TabIndex = 96;
            this.label4.Text = "ID";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1736, 1150);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(200, 88);
            this.CancelButton.TabIndex = 95;
            this.CancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.CancelButton, "Cancel");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1440, 1150);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 88);
            this.SaveButton.TabIndex = 94;
            this.SaveButton.Text = "Save";
            this.toolTip1.SetToolTip(this.SaveButton, "Save the modified product.");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTextBox.Location = new System.Drawing.Point(652, 792);
            this.MinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinTextBox.Multiline = true;
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(196, 87);
            this.MinTextBox.TabIndex = 93;
            this.toolTip1.SetToolTip(this.MinTextBox, "Please enter a number.");
            this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            this.MinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinTextBox_KeyPress);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTextBox.Location = new System.Drawing.Point(268, 792);
            this.MaxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaxTextBox.Multiline = true;
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(196, 87);
            this.MaxTextBox.TabIndex = 92;
            this.toolTip1.SetToolTip(this.MaxTextBox, "Please enter a number.");
            this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            this.MaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxTextBox_KeyPress);
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostTextBox.Location = new System.Drawing.Point(268, 637);
            this.PriceCostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceCostTextBox.Multiline = true;
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(360, 87);
            this.PriceCostTextBox.TabIndex = 91;
            this.toolTip1.SetToolTip(this.PriceCostTextBox, "Please enter a number.");
            this.PriceCostTextBox.TextChanged += new System.EventHandler(this.PriceCostTextBox_TextChanged);
            this.PriceCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceCostTextBox_KeyPress);
            // 
            // InvTextBox
            // 
            this.InvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvTextBox.Location = new System.Drawing.Point(268, 494);
            this.InvTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InvTextBox.Multiline = true;
            this.InvTextBox.Name = "InvTextBox";
            this.InvTextBox.Size = new System.Drawing.Size(360, 87);
            this.InvTextBox.TabIndex = 90;
            this.toolTip1.SetToolTip(this.InvTextBox, "Please enter a number.");
            this.InvTextBox.TextChanged += new System.EventHandler(this.InvTextBox_TextChanged);
            this.InvTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(268, 348);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(360, 87);
            this.NameTextBox.TabIndex = 89;
            this.toolTip1.SetToolTip(this.NameTextBox, "Please enter a name.");
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(268, 215);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(360, 87);
            this.IDTextBox.TabIndex = 88;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.AutoSize = true;
            this.ModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProduct.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ModifyProduct.Location = new System.Drawing.Point(152, 98);
            this.ModifyProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(324, 51);
            this.ModifyProduct.TabIndex = 87;
            this.ModifyProduct.Text = "Modify Product";
            // 
            // AssociatedParts
            // 
            this.AssociatedParts.AutoSize = true;
            this.AssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssociatedParts.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AssociatedParts.Location = new System.Drawing.Point(938, 667);
            this.AssociatedParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AssociatedParts.Name = "AssociatedParts";
            this.AssociatedParts.Size = new System.Drawing.Size(460, 31);
            this.AssociatedParts.TabIndex = 109;
            this.AssociatedParts.Text = "Associated Parts For This Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(938, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 108;
            this.label1.Text = "All Parts";
            // 
            // AssociatedPartsDataGridView
            // 
            this.AssociatedPartsDataGridView.AllowUserToAddRows = false;
            this.AssociatedPartsDataGridView.AllowUserToDeleteRows = false;
            this.AssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsDataGridView.Location = new System.Drawing.Point(962, 747);
            this.AssociatedPartsDataGridView.Name = "AssociatedPartsDataGridView";
            this.AssociatedPartsDataGridView.ReadOnly = true;
            this.AssociatedPartsDataGridView.RowTemplate.Height = 33;
            this.AssociatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsDataGridView.Size = new System.Drawing.Size(974, 229);
            this.AssociatedPartsDataGridView.TabIndex = 110;
            this.AssociatedPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataGridView_CellClick);
            this.AssociatedPartsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataGridView_CellContentClick);
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2006, 1346);
            this.Controls.Add(this.AssociatedPartsDataGridView);
            this.Controls.Add(this.AssociatedParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsSearchTextBox);
            this.Controls.Add(this.PartsDataGridView);
            this.Controls.Add(this.PartsSearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.PriceCostTextBox);
            this.Controls.Add(this.InvTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.ModifyProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProduct";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartsSearchTextBox;
        private System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.Button PartsSearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox PriceCostTextBox;
        private System.Windows.Forms.TextBox InvTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label ModifyProduct;
        private System.Windows.Forms.Label AssociatedParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView AssociatedPartsDataGridView;
    }
}