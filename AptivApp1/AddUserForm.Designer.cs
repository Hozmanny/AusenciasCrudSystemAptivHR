namespace AptivApp1
{
    partial class AddUserForm
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
            this.TxAddUserTitle = new System.Windows.Forms.Label();
            this.TBemailuser = new System.Windows.Forms.MaskedTextBox();
            this.Txemailuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBpassworduser = new System.Windows.Forms.MaskedTextBox();
            this.Txnameuser = new System.Windows.Forms.Label();
            this.TBnameuser = new System.Windows.Forms.MaskedTextBox();
            this.BTNadduser = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBregistred = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TxAddUserTitle
            // 
            this.TxAddUserTitle.AutoSize = true;
            this.TxAddUserTitle.Font = new System.Drawing.Font("Roboto Lt", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxAddUserTitle.ForeColor = System.Drawing.Color.White;
            this.TxAddUserTitle.Location = new System.Drawing.Point(70, 74);
            this.TxAddUserTitle.Name = "TxAddUserTitle";
            this.TxAddUserTitle.Size = new System.Drawing.Size(720, 61);
            this.TxAddUserTitle.TabIndex = 6;
            this.TxAddUserTitle.Text = "Agregar usuario de aplicación";
            this.TxAddUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBemailuser
            // 
            this.TBemailuser.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemailuser.Location = new System.Drawing.Point(257, 208);
            this.TBemailuser.Name = "TBemailuser";
            this.TBemailuser.Size = new System.Drawing.Size(516, 44);
            this.TBemailuser.TabIndex = 7;
            // 
            // Txemailuser
            // 
            this.Txemailuser.AutoSize = true;
            this.Txemailuser.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txemailuser.ForeColor = System.Drawing.Color.White;
            this.Txemailuser.Location = new System.Drawing.Point(70, 208);
            this.Txemailuser.Name = "Txemailuser";
            this.Txemailuser.Size = new System.Drawing.Size(143, 51);
            this.Txemailuser.TabIndex = 8;
            this.Txemailuser.Text = "E-mail";
            this.Txemailuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBpassworduser
            // 
            this.TBpassworduser.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassworduser.Location = new System.Drawing.Point(341, 295);
            this.TBpassworduser.Name = "TBpassworduser";
            this.TBpassworduser.Size = new System.Drawing.Size(434, 44);
            this.TBpassworduser.TabIndex = 10;
            this.TBpassworduser.UseSystemPasswordChar = true;
            // 
            // Txnameuser
            // 
            this.Txnameuser.AutoSize = true;
            this.Txnameuser.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txnameuser.ForeColor = System.Drawing.Color.White;
            this.Txnameuser.Location = new System.Drawing.Point(72, 380);
            this.Txnameuser.Name = "Txnameuser";
            this.Txnameuser.Size = new System.Drawing.Size(171, 51);
            this.Txnameuser.TabIndex = 11;
            this.Txnameuser.Text = "Nombre";
            this.Txnameuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBnameuser
            // 
            this.TBnameuser.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnameuser.Location = new System.Drawing.Point(257, 380);
            this.TBnameuser.Name = "TBnameuser";
            this.TBnameuser.Size = new System.Drawing.Size(516, 44);
            this.TBnameuser.TabIndex = 12;
            // 
            // BTNadduser
            // 
            this.BTNadduser.BackgroundImage = global::AptivApp1.Properties.Resources.addbackground;
            this.BTNadduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNadduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNadduser.FlatAppearance.BorderSize = 0;
            this.BTNadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNadduser.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadduser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNadduser.Location = new System.Drawing.Point(294, 522);
            this.BTNadduser.Name = "BTNadduser";
            this.BTNadduser.Size = new System.Drawing.Size(300, 50);
            this.BTNadduser.TabIndex = 13;
            this.BTNadduser.Text = "Agregar";
            this.BTNadduser.UseVisualStyleBackColor = true;
            this.BTNadduser.Click += new System.EventHandler(this.BTNadduser_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(346, 466);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(82, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Permiso Super Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBregistred
            // 
            this.TBregistred.Enabled = false;
            this.TBregistred.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBregistred.Location = new System.Drawing.Point(788, 380);
            this.TBregistred.Name = "TBregistred";
            this.TBregistred.Size = new System.Drawing.Size(46, 44);
            this.TBregistred.TabIndex = 16;
            this.TBregistred.Visible = false;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 965);
            this.Controls.Add(this.TBregistred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTNadduser);
            this.Controls.Add(this.TBnameuser);
            this.Controls.Add(this.Txnameuser);
            this.Controls.Add(this.TBpassworduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txemailuser);
            this.Controls.Add(this.TBemailuser);
            this.Controls.Add(this.TxAddUserTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxAddUserTitle;
        private System.Windows.Forms.MaskedTextBox TBemailuser;
        private System.Windows.Forms.Label Txemailuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TBpassworduser;
        private System.Windows.Forms.Label Txnameuser;
        private System.Windows.Forms.MaskedTextBox TBnameuser;
        private System.Windows.Forms.Button BTNadduser;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox TBregistred;
    }
}