namespace RentalApplication
{
    partial class RentalItemsForm
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
            this.labelRentalNewItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDetailItems = new System.Windows.Forms.DataGridView();
            this.listBoxRentalItem = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnRemoveRental = new System.Windows.Forms.Button();
            this.btnCancelRental = new System.Windows.Forms.Button();
            this.btnSaveRental = new System.Windows.Forms.Button();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailItems)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRentalNewItem
            // 
            this.labelRentalNewItem.BackColor = System.Drawing.Color.White;
            this.labelRentalNewItem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalNewItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRentalNewItem.Location = new System.Drawing.Point(12, 9);
            this.labelRentalNewItem.Name = "labelRentalNewItem";
            this.labelRentalNewItem.Size = new System.Drawing.Size(460, 30);
            this.labelRentalNewItem.TabIndex = 1;
            this.labelRentalNewItem.Text = "RENTAL NEW ITEMS";
            this.labelRentalNewItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item List";
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 16;
            this.listBoxItem.Location = new System.Drawing.Point(12, 69);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(227, 132);
            this.listBoxItem.TabIndex = 3;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(245, 69);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(227, 132);
            this.textBoxDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Detail List";
            // 
            // dataGridViewDetailItems
            // 
            this.dataGridViewDetailItems.AllowUserToAddRows = false;
            this.dataGridViewDetailItems.AllowUserToDeleteRows = false;
            this.dataGridViewDetailItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailItems.Location = new System.Drawing.Point(12, 229);
            this.dataGridViewDetailItems.Name = "dataGridViewDetailItems";
            this.dataGridViewDetailItems.ReadOnly = true;
            this.dataGridViewDetailItems.Size = new System.Drawing.Size(227, 132);
            this.dataGridViewDetailItems.TabIndex = 7;
            // 
            // listBoxRentalItem
            // 
            this.listBoxRentalItem.FormattingEnabled = true;
            this.listBoxRentalItem.ItemHeight = 16;
            this.listBoxRentalItem.Location = new System.Drawing.Point(245, 229);
            this.listBoxRentalItem.Name = "listBoxRentalItem";
            this.listBoxRentalItem.Size = new System.Drawing.Size(227, 132);
            this.listBoxRentalItem.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rental Item List";
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(12, 426);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(125, 23);
            this.btnAddRental.TabIndex = 10;
            this.btnAddRental.Text = "Add To Rental List";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnRemoveRental
            // 
            this.btnRemoveRental.Location = new System.Drawing.Point(143, 426);
            this.btnRemoveRental.Name = "btnRemoveRental";
            this.btnRemoveRental.Size = new System.Drawing.Size(167, 23);
            this.btnRemoveRental.TabIndex = 11;
            this.btnRemoveRental.Text = "Remove From Rental List";
            this.btnRemoveRental.UseVisualStyleBackColor = true;
            this.btnRemoveRental.Click += new System.EventHandler(this.btnRemoveRental_Click);
            // 
            // btnCancelRental
            // 
            this.btnCancelRental.Location = new System.Drawing.Point(397, 426);
            this.btnCancelRental.Name = "btnCancelRental";
            this.btnCancelRental.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRental.TabIndex = 12;
            this.btnCancelRental.Text = "Cancel";
            this.btnCancelRental.UseVisualStyleBackColor = true;
            this.btnCancelRental.Click += new System.EventHandler(this.btnCancelRental_Click);
            // 
            // btnSaveRental
            // 
            this.btnSaveRental.Location = new System.Drawing.Point(316, 426);
            this.btnSaveRental.Name = "btnSaveRental";
            this.btnSaveRental.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRental.TabIndex = 13;
            this.btnSaveRental.Text = "Save";
            this.btnSaveRental.UseVisualStyleBackColor = true;
            this.btnSaveRental.Click += new System.EventHandler(this.btnSaveRental_Click);
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(12, 389);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.ReadOnly = true;
            this.textBoxMemberId.Size = new System.Drawing.Size(227, 22);
            this.textBoxMemberId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Member ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Member Name";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(245, 389);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.ReadOnly = true;
            this.textBoxMemberName.Size = new System.Drawing.Size(227, 22);
            this.textBoxMemberName.TabIndex = 17;
            // 
            // RentalItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.btnSaveRental);
            this.Controls.Add(this.btnCancelRental);
            this.Controls.Add(this.btnRemoveRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxRentalItem);
            this.Controls.Add(this.dataGridViewDetailItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRentalNewItem);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RentalItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental New Items";
            this.Load += new System.EventHandler(this.RentalItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelRentalNewItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDetailItems;
        private System.Windows.Forms.ListBox listBoxRentalItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnRemoveRental;
        private System.Windows.Forms.Button btnCancelRental;
        private System.Windows.Forms.Button btnSaveRental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxMemberId;
        public System.Windows.Forms.TextBox textBoxMemberName;
    }
}