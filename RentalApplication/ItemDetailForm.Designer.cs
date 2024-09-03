namespace RentalApplication
{
    partial class ItemDetailForm
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
            this.labelDetailForm = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveDetailItem = new System.Windows.Forms.Button();
            this.btnCancelDetailItem = new System.Windows.Forms.Button();
            this.textBoxDetailNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDetailForm
            // 
            this.labelDetailForm.BackColor = System.Drawing.Color.White;
            this.labelDetailForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDetailForm.Location = new System.Drawing.Point(12, 9);
            this.labelDetailForm.Name = "labelDetailForm";
            this.labelDetailForm.Size = new System.Drawing.Size(460, 30);
            this.labelDetailForm.TabIndex = 2;
            this.labelDetailForm.Text = "ADD/EDIT DETAIL ITEM";
            this.labelDetailForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(172, 57);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.ReadOnly = true;
            this.textBoxProductId.Size = new System.Drawing.Size(300, 21);
            this.textBoxProductId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item ID";
            // 
            // btnSaveDetailItem
            // 
            this.btnSaveDetailItem.Location = new System.Drawing.Point(316, 200);
            this.btnSaveDetailItem.Name = "btnSaveDetailItem";
            this.btnSaveDetailItem.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDetailItem.TabIndex = 15;
            this.btnSaveDetailItem.Text = "Save";
            this.btnSaveDetailItem.UseVisualStyleBackColor = true;
            this.btnSaveDetailItem.Click += new System.EventHandler(this.btnSaveDetailItem_Click);
            // 
            // btnCancelDetailItem
            // 
            this.btnCancelDetailItem.Location = new System.Drawing.Point(397, 200);
            this.btnCancelDetailItem.Name = "btnCancelDetailItem";
            this.btnCancelDetailItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDetailItem.TabIndex = 14;
            this.btnCancelDetailItem.Text = "Cancel";
            this.btnCancelDetailItem.UseVisualStyleBackColor = true;
            this.btnCancelDetailItem.Click += new System.EventHandler(this.btnCancelDetailItem_Click);
            // 
            // textBoxDetailNote
            // 
            this.textBoxDetailNote.Location = new System.Drawing.Point(172, 137);
            this.textBoxDetailNote.Multiline = true;
            this.textBoxDetailNote.Name = "textBoxDetailNote";
            this.textBoxDetailNote.Size = new System.Drawing.Size(300, 50);
            this.textBoxDetailNote.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Item Detail Note";
            // 
            // textBoxIdDetail
            // 
            this.textBoxIdDetail.Location = new System.Drawing.Point(172, 97);
            this.textBoxIdDetail.Name = "textBoxIdDetail";
            this.textBoxIdDetail.ReadOnly = true;
            this.textBoxIdDetail.Size = new System.Drawing.Size(300, 21);
            this.textBoxIdDetail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Detail ID";
            // 
            // ItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveDetailItem);
            this.Controls.Add(this.btnCancelDetailItem);
            this.Controls.Add(this.textBoxDetailNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDetailForm);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Detail Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelDetailForm;
        public System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveDetailItem;
        private System.Windows.Forms.Button btnCancelDetailItem;
        public System.Windows.Forms.TextBox textBoxDetailNote;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxIdDetail;
        private System.Windows.Forms.Label label1;
    }
}