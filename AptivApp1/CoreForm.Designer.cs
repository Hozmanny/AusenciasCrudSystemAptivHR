namespace AptivApp1
{
    partial class CoreForm
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
            this.BTNminimizar = new System.Windows.Forms.Button();
            this.BTNcerrar = new System.Windows.Forms.Button();
            this.TittleBar = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.LBname = new System.Windows.Forms.Label();
            this.BTNclosesession = new System.Windows.Forms.Button();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.BTNevents = new System.Windows.Forms.Button();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.BTNemployees = new System.Windows.Forms.Button();
            this.BTNaddUser = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.TittleBar.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelEmpleados.SuspendLayout();
            this.SuspendLayout();
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
            // TittleBar
            // 
            this.TittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.TittleBar.Controls.Add(this.BTNminimizar);
            this.TittleBar.Controls.Add(this.BTNcerrar);
            this.TittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittleBar.Location = new System.Drawing.Point(0, 0);
            this.TittleBar.Name = "TittleBar";
            this.TittleBar.Size = new System.Drawing.Size(1300, 35);
            this.TittleBar.TabIndex = 1;
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.panelSide.Controls.Add(this.LBname);
            this.panelSide.Controls.Add(this.BTNclosesession);
            this.panelSide.Controls.Add(this.panelEmpleados);
            this.panelSide.Controls.Add(this.BTNemployees);
            this.panelSide.Controls.Add(this.BTNaddUser);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 35);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(400, 965);
            this.panelSide.TabIndex = 2;
            // 
            // LBname
            // 
            this.LBname.AutoSize = true;
            this.LBname.ForeColor = System.Drawing.Color.White;
            this.LBname.Location = new System.Drawing.Point(25, 939);
            this.LBname.Name = "LBname";
            this.LBname.Size = new System.Drawing.Size(46, 17);
            this.LBname.TabIndex = 7;
            this.LBname.Text = "label1";
            // 
            // BTNclosesession
            // 
            this.BTNclosesession.BackgroundImage = global::AptivApp1.Properties.Resources.btnback5;
            this.BTNclosesession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNclosesession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNclosesession.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNclosesession.FlatAppearance.BorderSize = 0;
            this.BTNclosesession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNclosesession.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclosesession.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNclosesession.Location = new System.Drawing.Point(0, 430);
            this.BTNclosesession.Name = "BTNclosesession";
            this.BTNclosesession.Padding = new System.Windows.Forms.Padding(95, 0, 0, 0);
            this.BTNclosesession.Size = new System.Drawing.Size(400, 75);
            this.BTNclosesession.TabIndex = 6;
            this.BTNclosesession.Text = "Cerrar sesión";
            this.BTNclosesession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNclosesession.UseVisualStyleBackColor = true;
            this.BTNclosesession.Click += new System.EventHandler(this.BTNclosesession_Click);
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.panelEmpleados.Controls.Add(this.BTNevents);
            this.panelEmpleados.Controls.Add(this.BTNsearch);
            this.panelEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleados.Location = new System.Drawing.Point(0, 280);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(400, 150);
            this.panelEmpleados.TabIndex = 3;
            // 
            // BTNevents
            // 
            this.BTNevents.BackgroundImage = global::AptivApp1.Properties.Resources.btnback4;
            this.BTNevents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNevents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNevents.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNevents.FlatAppearance.BorderSize = 0;
            this.BTNevents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(17)))));
            this.BTNevents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNevents.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNevents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNevents.Location = new System.Drawing.Point(0, 75);
            this.BTNevents.Name = "BTNevents";
            this.BTNevents.Padding = new System.Windows.Forms.Padding(125, 0, 0, 0);
            this.BTNevents.Size = new System.Drawing.Size(400, 75);
            this.BTNevents.TabIndex = 1;
            this.BTNevents.Text = "Eventos";
            this.BTNevents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNevents.UseVisualStyleBackColor = true;
            this.BTNevents.Click += new System.EventHandler(this.BTNevents_Click);
            // 
            // BTNsearch
            // 
            this.BTNsearch.BackgroundImage = global::AptivApp1.Properties.Resources.btnback3;
            this.BTNsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNsearch.FlatAppearance.BorderSize = 0;
            this.BTNsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(17)))));
            this.BTNsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNsearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNsearch.Location = new System.Drawing.Point(0, 0);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Padding = new System.Windows.Forms.Padding(125, 0, 0, 0);
            this.BTNsearch.Size = new System.Drawing.Size(400, 75);
            this.BTNsearch.TabIndex = 0;
            this.BTNsearch.Text = "Buscar registros";
            this.BTNsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // BTNemployees
            // 
            this.BTNemployees.BackgroundImage = global::AptivApp1.Properties.Resources.btnback2;
            this.BTNemployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNemployees.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.BTNemployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNemployees.FlatAppearance.BorderSize = 0;
            this.BTNemployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNemployees.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNemployees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNemployees.Location = new System.Drawing.Point(0, 205);
            this.BTNemployees.Name = "BTNemployees";
            this.BTNemployees.Padding = new System.Windows.Forms.Padding(95, 0, 0, 0);
            this.BTNemployees.Size = new System.Drawing.Size(400, 75);
            this.BTNemployees.TabIndex = 5;
            this.BTNemployees.Text = "Empleados";
            this.BTNemployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNemployees.UseVisualStyleBackColor = true;
            this.BTNemployees.Click += new System.EventHandler(this.BTNemployees_Click);
            // 
            // BTNaddUser
            // 
            this.BTNaddUser.BackgroundImage = global::AptivApp1.Properties.Resources.btnback1;
            this.BTNaddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNaddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNaddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNaddUser.FlatAppearance.BorderSize = 0;
            this.BTNaddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNaddUser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNaddUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNaddUser.Location = new System.Drawing.Point(0, 130);
            this.BTNaddUser.Name = "BTNaddUser";
            this.BTNaddUser.Padding = new System.Windows.Forms.Padding(95, 0, 0, 0);
            this.BTNaddUser.Size = new System.Drawing.Size(400, 75);
            this.BTNaddUser.TabIndex = 4;
            this.BTNaddUser.Text = "Agregar usuario de app";
            this.BTNaddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNaddUser.UseVisualStyleBackColor = true;
            this.BTNaddUser.Click += new System.EventHandler(this.BTNaddUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::AptivApp1.Properties.Resources.aptiv_logo_rev_orange_rgb1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(400, 130);
            this.panelLogo.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(400, 35);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(900, 965);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AptivApp1.Properties.Resources.bienvenido;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1300, 1000);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.TittleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoreForm";
            this.TittleBar.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelEmpleados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNminimizar;
        private System.Windows.Forms.Button BTNcerrar;
        private System.Windows.Forms.Panel TittleBar;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button BTNevents;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.Button BTNemployees;
        private System.Windows.Forms.Button BTNclosesession;
        private System.Windows.Forms.Panel panelChildForm;
        public System.Windows.Forms.Label LBname;
        public System.Windows.Forms.Button BTNaddUser;
    }
}