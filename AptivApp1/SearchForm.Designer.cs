namespace AptivApp1
{
    partial class SearchForm
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
            this.Txemailuser = new System.Windows.Forms.Label();
            this.TBstartsearch = new System.Windows.Forms.MaskedTextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BTNimprimir = new System.Windows.Forms.Button();
            this.BTNadduser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // TxAddUserTitle
            // 
            this.TxAddUserTitle.AutoSize = true;
            this.TxAddUserTitle.Font = new System.Drawing.Font("Roboto Lt", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxAddUserTitle.ForeColor = System.Drawing.Color.White;
            this.TxAddUserTitle.Location = new System.Drawing.Point(225, 54);
            this.TxAddUserTitle.Name = "TxAddUserTitle";
            this.TxAddUserTitle.Size = new System.Drawing.Size(412, 61);
            this.TxAddUserTitle.TabIndex = 15;
            this.TxAddUserTitle.Text = "Buscar registros";
            this.TxAddUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txemailuser
            // 
            this.Txemailuser.AutoSize = true;
            this.Txemailuser.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txemailuser.ForeColor = System.Drawing.Color.White;
            this.Txemailuser.Location = new System.Drawing.Point(65, 166);
            this.Txemailuser.Name = "Txemailuser";
            this.Txemailuser.Size = new System.Drawing.Size(273, 51);
            this.Txemailuser.TabIndex = 18;
            this.Txemailuser.Text = "Número emp.";
            this.Txemailuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBstartsearch
            // 
            this.TBstartsearch.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBstartsearch.Location = new System.Drawing.Point(371, 173);
            this.TBstartsearch.Name = "TBstartsearch";
            this.TBstartsearch.Size = new System.Drawing.Size(393, 44);
            this.TBstartsearch.TabIndex = 17;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Location = new System.Drawing.Point(74, 364);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(690, 406);
            this.DgvListado.TabIndex = 24;
            // 
            // BTNimprimir
            // 
            this.BTNimprimir.BackgroundImage = global::AptivApp1.Properties.Resources.printbackground;
            this.BTNimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNimprimir.FlatAppearance.BorderSize = 0;
            this.BTNimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNimprimir.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNimprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNimprimir.Location = new System.Drawing.Point(474, 816);
            this.BTNimprimir.Name = "BTNimprimir";
            this.BTNimprimir.Size = new System.Drawing.Size(290, 50);
            this.BTNimprimir.TabIndex = 23;
            this.BTNimprimir.Text = "Imprimir";
            this.BTNimprimir.UseVisualStyleBackColor = true;
            this.BTNimprimir.Click += new System.EventHandler(this.BTNimprimir_Click);
            // 
            // BTNadduser
            // 
            this.BTNadduser.BackgroundImage = global::AptivApp1.Properties.Resources.searchbackground;
            this.BTNadduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNadduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNadduser.FlatAppearance.BorderSize = 0;
            this.BTNadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNadduser.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadduser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNadduser.Location = new System.Drawing.Point(474, 260);
            this.BTNadduser.Name = "BTNadduser";
            this.BTNadduser.Size = new System.Drawing.Size(290, 50);
            this.BTNadduser.TabIndex = 22;
            this.BTNadduser.Text = "Buscar";
            this.BTNadduser.UseVisualStyleBackColor = true;
            this.BTNadduser.Click += new System.EventHandler(this.BTNadduser_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 918);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BTNimprimir);
            this.Controls.Add(this.BTNadduser);
            this.Controls.Add(this.Txemailuser);
            this.Controls.Add(this.TBstartsearch);
            this.Controls.Add(this.TxAddUserTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "            ";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxAddUserTitle;
        private System.Windows.Forms.Label Txemailuser;
        private System.Windows.Forms.MaskedTextBox TBstartsearch;
        private System.Windows.Forms.Button BTNadduser;
        private System.Windows.Forms.Button BTNimprimir;
        private System.Windows.Forms.DataGridView DgvListado;
    }
}