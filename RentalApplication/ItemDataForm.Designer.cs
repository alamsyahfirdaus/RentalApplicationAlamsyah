namespace RentalApplication
{
    partial class ItemDataForm
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
            this.labelItemForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdProduct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelItemForm
            // 
            this.labelItemForm.BackColor = System.Drawing.Color.White;
            this.labelItemForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelItemForm.Location = new System.Drawing.Point(12, 9);
            this.labelItemForm.Name = "labelItemForm";
            this.labelItemForm.Size = new System.Drawing.Size(460, 30);
            this.labelItemForm.TabIndex = 1;
            this.labelItemForm.Text = "ADD/EDIT ITEM";
            this.labelItemForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(172, 97);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(300, 22);
            this.textBoxProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(172, 137);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(300, 50);
            this.textBoxDescription.TabIndex = 5;
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(397, 200);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelItem.TabIndex = 6;
            this.btnCancelItem.Text = "Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(316, 200);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(75, 23);
            this.btnSaveItem.TabIndex = 7;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item ID";
            // 
            // textBoxIdProduct
            // 
            this.textBoxIdProduct.Location = new System.Drawing.Point(172, 54);
            this.textBoxIdProduct.Name = "textBoxIdProduct";
            this.textBoxIdProduct.ReadOnly = true;
            this.textBoxIdProduct.Size = new System.Drawing.Size(300, 22);
            this.textBoxIdProduct.TabIndex = 9;
            // 
            // ItemDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.textBoxIdProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelItemForm);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelItemForm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxIdProduct;
    }
}