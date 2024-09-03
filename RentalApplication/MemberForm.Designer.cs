namespace RentalApplication
{
    partial class MemberForm
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
            this.textBoxIdMember = new System.Windows.Forms.TextBox();
            this.labelMemberForm = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.btnCancelMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdMember
            // 
            this.textBoxIdMember.Location = new System.Drawing.Point(172, 57);
            this.textBoxIdMember.Name = "textBoxIdMember";
            this.textBoxIdMember.ReadOnly = true;
            this.textBoxIdMember.Size = new System.Drawing.Size(300, 22);
            this.textBoxIdMember.TabIndex = 1;
            // 
            // labelMemberForm
            // 
            this.labelMemberForm.BackColor = System.Drawing.Color.White;
            this.labelMemberForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMemberForm.Location = new System.Drawing.Point(12, 9);
            this.labelMemberForm.Name = "labelMemberForm";
            this.labelMemberForm.Size = new System.Drawing.Size(460, 30);
            this.labelMemberForm.TabIndex = 0;
            this.labelMemberForm.Text = "ADD/EDIT MEMBER";
            this.labelMemberForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(172, 97);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(300, 22);
            this.textBoxMemberName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(172, 137);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(300, 22);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(172, 177);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(300, 22);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.Location = new System.Drawing.Point(316, 210);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMember.TabIndex = 9;
            this.btnSaveMember.Text = "Save";
            this.btnSaveMember.UseVisualStyleBackColor = true;
            this.btnSaveMember.Click += new System.EventHandler(this.btnSaveMember_Click);
            // 
            // btnCancelMember
            // 
            this.btnCancelMember.Location = new System.Drawing.Point(397, 210);
            this.btnCancelMember.Name = "btnCancelMember";
            this.btnCancelMember.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMember.TabIndex = 10;
            this.btnCancelMember.Text = "Cancel";
            this.btnCancelMember.UseVisualStyleBackColor = true;
            this.btnCancelMember.Click += new System.EventHandler(this.btnCancelMember_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnCancelMember);
            this.Controls.Add(this.btnSaveMember);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.textBoxIdMember);
            this.Controls.Add(this.labelMemberForm);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Member";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxIdMember;
        public System.Windows.Forms.Label labelMemberForm;
        public System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxPhoneNumber;
        public System.Windows.Forms.Button btnSaveMember;
        public System.Windows.Forms.Button btnCancelMember;

    }
}