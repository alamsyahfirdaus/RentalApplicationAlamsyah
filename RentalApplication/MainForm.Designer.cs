namespace RentalApplication
{
    partial class MainForm
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
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenageItems = new System.Windows.Forms.Button();
            this.btnReturnRentalItem = new System.Windows.Forms.Button();
            this.btnRentalNewItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.ReadOnly = true;
            this.dataGridViewMember.Size = new System.Drawing.Size(460, 150);
            this.dataGridViewMember.TabIndex = 0;
            this.dataGridViewMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMember_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "RENTAL APPLICATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member List";
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.Location = new System.Drawing.Point(85, 225);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(125, 23);
            this.btnAddNewMember.TabIndex = 3;
            this.btnAddNewMember.Text = "Add New Member";
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(347, 225);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteMember.TabIndex = 5;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Location = new System.Drawing.Point(216, 225);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(125, 23);
            this.btnEditMember.TabIndex = 6;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AllowUserToAddRows = false;
            this.dataGridViewRental.AllowUserToDeleteRows = false;
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(12, 270);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.ReadOnly = true;
            this.dataGridViewRental.Size = new System.Drawing.Size(460, 150);
            this.dataGridViewRental.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rental Items";
            // 
            // btnMenageItems
            // 
            this.btnMenageItems.Location = new System.Drawing.Point(372, 426);
            this.btnMenageItems.Name = "btnMenageItems";
            this.btnMenageItems.Size = new System.Drawing.Size(100, 25);
            this.btnMenageItems.TabIndex = 9;
            this.btnMenageItems.Text = "Menage Items";
            this.btnMenageItems.UseVisualStyleBackColor = true;
            this.btnMenageItems.Click += new System.EventHandler(this.btnMenageItems_Click);
            // 
            // btnReturnRentalItem
            // 
            this.btnReturnRentalItem.Location = new System.Drawing.Point(241, 426);
            this.btnReturnRentalItem.Name = "btnReturnRentalItem";
            this.btnReturnRentalItem.Size = new System.Drawing.Size(125, 25);
            this.btnReturnRentalItem.TabIndex = 10;
            this.btnReturnRentalItem.Text = "Return Rental Item";
            this.btnReturnRentalItem.UseVisualStyleBackColor = true;
            this.btnReturnRentalItem.Click += new System.EventHandler(this.btnReturnRentalItem_Click);
            // 
            // btnRentalNewItems
            // 
            this.btnRentalNewItems.Location = new System.Drawing.Point(110, 426);
            this.btnRentalNewItems.Name = "btnRentalNewItems";
            this.btnRentalNewItems.Size = new System.Drawing.Size(125, 25);
            this.btnRentalNewItems.TabIndex = 11;
            this.btnRentalNewItems.Text = "Rental New Items";
            this.btnRentalNewItems.UseVisualStyleBackColor = true;
            this.btnRentalNewItems.Click += new System.EventHandler(this.btnRentalNewItems_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnRentalNewItems);
            this.Controls.Add(this.btnReturnRentalItem);
            this.Controls.Add(this.btnMenageItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewRental);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnAddNewMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMember);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMenageItems;
        private System.Windows.Forms.Button btnReturnRentalItem;
        private System.Windows.Forms.Button btnRentalNewItems;
    }
}

