namespace AptivApp1
{
    partial class SessionForm
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
            this.TittleBar = new System.Windows.Forms.Panel();
            this.BTNminimizar = new System.Windows.Forms.Button();
            this.BTNcerrar = new System.Windows.Forms.Button();
            this.PanelInicioSesion = new System.Windows.Forms.Panel();
            this.BTNiniciarsesion = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.MaskedTextBox();
            this.Txcontrasena = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.MaskedTextBox();
            this.TxCorreo = new System.Windows.Forms.Label();
            this.TxInicioSesion = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TittleBar.SuspendLayout();
            this.PanelInicioSesion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TittleBar
            // 
            this.TittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.TittleBar.Controls.Add(this.BTNminimizar);
            this.TittleBar.Controls.Add(this.BTNcerrar);
            this.TittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittleBar.Location = new System.Drawing.Point(0, 0);
            this.TittleBar.Name = "TittleBar";
            this.TittleBar.Size = new System.Drawing.Size(1300, 35);
            this.TittleBar.TabIndex = 0;
            // 
            // BTNminimizar
            // 
            this.BTNminimizar.BackgroundImage = global::AptivApp1.Properties.Resources.BTNmin;
            this.BTNminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNminimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.BTNminimizar.Location = new System.Drawing.Point(1200, 0);
            this.BTNminimizar.Name = "BTNminimizar";
            this.BTNminimizar.Size = new System.Drawing.Size(35, 35);
            this.BTNminimizar.TabIndex = 2;
            this.BTNminimizar.UseVisualStyleBackColor = true;
            // 
            // BTNcerrar
            // 
            this.BTNcerrar.BackgroundImage = global::AptivApp1.Properties.Resources.BTNcerrar;
            this.BTNcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.BTNcerrar.Location = new System.Drawing.Point(1253, 0);
            this.BTNcerrar.Name = "BTNcerrar";
            this.BTNcerrar.Size = new System.Drawing.Size(35, 35);
            this.BTNcerrar.TabIndex = 1;
            this.BTNcerrar.UseVisualStyleBackColor = true;
            // 
            // PanelInicioSesion
            // 
            this.PanelInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.PanelInicioSesion.Controls.Add(this.BTNiniciarsesion);
            this.PanelInicioSesion.Controls.Add(this.TBPassword);
            this.PanelInicioSesion.Controls.Add(this.Txcontrasena);
            this.PanelInicioSesion.Controls.Add(this.TBEmail);
            this.PanelInicioSesion.Controls.Add(this.TxCorreo);
            this.PanelInicioSesion.Controls.Add(this.TxInicioSesion);
            this.PanelInicioSesion.Controls.Add(this.maskedTextBox1);
            this.PanelInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInicioSesion.Location = new System.Drawing.Point(0, 35);
            this.PanelInicioSesion.Name = "PanelInicioSesion";
            this.PanelInicioSesion.Size = new System.Drawing.Size(1300, 965);
            this.PanelInicioSesion.TabIndex = 0;
            // 
            // BTNiniciarsesion
            // 
            this.BTNiniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.BTNiniciarsesion.BackgroundImage = global::AptivApp1.Properties.Resources.BTNiniciarsesion;
            this.BTNiniciarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNiniciarsesion.FlatAppearance.BorderSize = 0;
            this.BTNiniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNiniciarsesion.Location = new System.Drawing.Point(477, 615);
            this.BTNiniciarsesion.Margin = new System.Windows.Forms.Padding(0);
            this.BTNiniciarsesion.Name = "BTNiniciarsesion";
            this.BTNiniciarsesion.Size = new System.Drawing.Size(355, 45);
            this.BTNiniciarsesion.TabIndex = 9;
            this.BTNiniciarsesion.UseVisualStyleBackColor = false;
            this.BTNiniciarsesion.Click += new System.EventHandler(this.BTNiniciarsesion_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Font = new System.Drawing.Font("Roboto Th", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(477, 492);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(355, 44);
            this.TBPassword.TabIndex = 8;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // Txcontrasena
            // 
            this.Txcontrasena.AutoSize = true;
            this.Txcontrasena.Font = new System.Drawing.Font("Roboto Th", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txcontrasena.ForeColor = System.Drawing.Color.White;
            this.Txcontrasena.Location = new System.Drawing.Point(470, 447);
            this.Txcontrasena.Name = "Txcontrasena";
            this.Txcontrasena.Size = new System.Drawing.Size(181, 41);
            this.Txcontrasena.TabIndex = 7;
            this.Txcontrasena.Text = "Contraseña";
            this.Txcontrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Roboto Th", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(477, 373);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(355, 44);
            this.TBEmail.TabIndex = 4;
            // 
            // TxCorreo
            // 
            this.TxCorreo.AutoSize = true;
            this.TxCorreo.Font = new System.Drawing.Font("Roboto Th", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxCorreo.ForeColor = System.Drawing.Color.White;
            this.TxCorreo.Location = new System.Drawing.Point(470, 328);
            this.TxCorreo.Name = "TxCorreo";
            this.TxCorreo.Size = new System.Drawing.Size(279, 41);
            this.TxCorreo.TabIndex = 6;
            this.TxCorreo.Text = "Correo electrónico";
            this.TxCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxInicioSesion
            // 
            this.TxInicioSesion.AutoSize = true;
            this.TxInicioSesion.Font = new System.Drawing.Font("Roboto Lt", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxInicioSesion.ForeColor = System.Drawing.Color.White;
            this.TxInicioSesion.Location = new System.Drawing.Point(466, 238);
            this.TxInicioSesion.Name = "TxInicioSesion";
            this.TxInicioSesion.Size = new System.Drawing.Size(366, 61);
            this.TxInicioSesion.TabIndex = 5;
            this.TxInicioSesion.Text = "Inicio de sesión";
            this.TxInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxInicioSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 200);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::AptivApp1.Properties.Resources.aptiv_logo_rev_orange_rgb;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(400, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 200);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 765);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(900, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 765);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(400, 874);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 126);
            this.panel4.TabIndex = 3;
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1300, 1000);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelInicioSesion);
            this.Controls.Add(this.TittleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TittleBar.ResumeLayout(false);
            this.PanelInicioSesion.ResumeLayout(false);
            this.PanelInicioSesion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TittleBar;
        private System.Windows.Forms.Panel PanelInicioSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label TxInicioSesion;
        private System.Windows.Forms.MaskedTextBox TBPassword;
        private System.Windows.Forms.Label Txcontrasena;
        private System.Windows.Forms.MaskedTextBox TBEmail;
        private System.Windows.Forms.Label TxCorreo;
        private System.Windows.Forms.Button BTNiniciarsesion;
        private System.Windows.Forms.Button BTNcerrar;
        private System.Windows.Forms.Button BTNminimizar;
    }
}

