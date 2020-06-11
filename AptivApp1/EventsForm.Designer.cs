namespace AptivApp1
{
    partial class EventsForm
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
            this.BTNadduser = new System.Windows.Forms.Button();
            this.TBnameemp = new System.Windows.Forms.MaskedTextBox();
            this.Txnameuser = new System.Windows.Forms.Label();
            this.Txemailuser = new System.Windows.Forms.Label();
            this.TBnumberemp = new System.Windows.Forms.MaskedTextBox();
            this.TxAddUserTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBlineemp = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBeventemp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPstartemp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPendemp = new System.Windows.Forms.DateTimePicker();
            this.CBworkshiftemp = new System.Windows.Forms.ComboBox();
            this.TBcommentemp = new System.Windows.Forms.TextBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.TBregistredbyemp = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
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
            this.BTNadduser.Location = new System.Drawing.Point(305, 867);
            this.BTNadduser.Name = "BTNadduser";
            this.BTNadduser.Size = new System.Drawing.Size(300, 50);
            this.BTNadduser.TabIndex = 21;
            this.BTNadduser.Text = "Agregar";
            this.BTNadduser.UseVisualStyleBackColor = true;
            this.BTNadduser.Click += new System.EventHandler(this.BTNadduser_Click);
            // 
            // TBnameemp
            // 
            this.TBnameemp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnameemp.Location = new System.Drawing.Point(252, 242);
            this.TBnameemp.Name = "TBnameemp";
            this.TBnameemp.Size = new System.Drawing.Size(516, 44);
            this.TBnameemp.TabIndex = 20;
            // 
            // Txnameuser
            // 
            this.Txnameuser.AutoSize = true;
            this.Txnameuser.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txnameuser.ForeColor = System.Drawing.Color.White;
            this.Txnameuser.Location = new System.Drawing.Point(65, 235);
            this.Txnameuser.Name = "Txnameuser";
            this.Txnameuser.Size = new System.Drawing.Size(171, 51);
            this.Txnameuser.TabIndex = 19;
            this.Txnameuser.Text = "Nombre";
            this.Txnameuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txemailuser
            // 
            this.Txemailuser.AutoSize = true;
            this.Txemailuser.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txemailuser.ForeColor = System.Drawing.Color.White;
            this.Txemailuser.Location = new System.Drawing.Point(65, 166);
            this.Txemailuser.Name = "Txemailuser";
            this.Txemailuser.Size = new System.Drawing.Size(273, 51);
            this.Txemailuser.TabIndex = 16;
            this.Txemailuser.Text = "Número emp.";
            this.Txemailuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBnumberemp
            // 
            this.TBnumberemp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnumberemp.Location = new System.Drawing.Point(375, 173);
            this.TBnumberemp.Name = "TBnumberemp";
            this.TBnumberemp.Size = new System.Drawing.Size(393, 44);
            this.TBnumberemp.TabIndex = 15;
            // 
            // TxAddUserTitle
            // 
            this.TxAddUserTitle.AutoSize = true;
            this.TxAddUserTitle.Font = new System.Drawing.Font("Roboto Lt", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxAddUserTitle.ForeColor = System.Drawing.Color.White;
            this.TxAddUserTitle.Location = new System.Drawing.Point(225, 54);
            this.TxAddUserTitle.Name = "TxAddUserTitle";
            this.TxAddUserTitle.Size = new System.Drawing.Size(380, 61);
            this.TxAddUserTitle.TabIndex = 14;
            this.TxAddUserTitle.Text = "Agregar evento";
            this.TxAddUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 51);
            this.label1.TabIndex = 22;
            this.label1.Text = "Linea";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBlineemp
            // 
            this.TBlineemp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBlineemp.Location = new System.Drawing.Point(252, 315);
            this.TBlineemp.Name = "TBlineemp";
            this.TBlineemp.Size = new System.Drawing.Size(186, 44);
            this.TBlineemp.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(463, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 51);
            this.label2.TabIndex = 24;
            this.label2.Text = "Turno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 51);
            this.label3.TabIndex = 27;
            this.label3.Text = "Comentario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBeventemp
            // 
            this.CBeventemp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBeventemp.FormattingEnabled = true;
            this.CBeventemp.Items.AddRange(new object[] {
            "Acta Administrativa",
            "Amonestación Verbal",
            "Amonestación Por Escrito",
            "Amonestación (Suspensión)",
            "Incapacidad por embarazo",
            "Incapacidad por asuntos diversos",
            "Incapacidad por enfermedad",
            "Otros",
            "Tarjeta Amarilla",
            "Vacaciones"});
            this.CBeventemp.Location = new System.Drawing.Point(252, 386);
            this.CBeventemp.Name = "CBeventemp";
            this.CBeventemp.Size = new System.Drawing.Size(516, 45);
            this.CBeventemp.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 51);
            this.label4.TabIndex = 29;
            this.label4.Text = "Evento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPstartemp
            // 
            this.DTPstartemp.CustomFormat = "yyy/MM/dd";
            this.DTPstartemp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPstartemp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPstartemp.Location = new System.Drawing.Point(252, 461);
            this.DTPstartemp.Name = "DTPstartemp";
            this.DTPstartemp.Size = new System.Drawing.Size(169, 32);
            this.DTPstartemp.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 39);
            this.label5.TabIndex = 31;
            this.label5.Text = "Inicio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Lt", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(439, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 39);
            this.label6.TabIndex = 33;
            this.label6.Text = "Termino";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPendemp
            // 
            this.DTPendemp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPendemp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPendemp.Location = new System.Drawing.Point(599, 463);
            this.DTPendemp.Name = "DTPendemp";
            this.DTPendemp.Size = new System.Drawing.Size(169, 32);
            this.DTPendemp.TabIndex = 32;
            this.DTPendemp.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // CBworkshiftemp
            // 
            this.CBworkshiftemp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBworkshiftemp.FormattingEnabled = true;
            this.CBworkshiftemp.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CBworkshiftemp.Location = new System.Drawing.Point(599, 314);
            this.CBworkshiftemp.Name = "CBworkshiftemp";
            this.CBworkshiftemp.Size = new System.Drawing.Size(169, 45);
            this.CBworkshiftemp.TabIndex = 34;
            // 
            // TBcommentemp
            // 
            this.TBcommentemp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcommentemp.Location = new System.Drawing.Point(74, 570);
            this.TBcommentemp.Multiline = true;
            this.TBcommentemp.Name = "TBcommentemp";
            this.TBcommentemp.Size = new System.Drawing.Size(694, 176);
            this.TBcommentemp.TabIndex = 35;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Lt", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 782);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 51);
            this.label7.TabIndex = 36;
            this.label7.Text = "Registra";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBregistredbyemp
            // 
            this.TBregistredbyemp.Enabled = false;
            this.TBregistredbyemp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBregistredbyemp.Location = new System.Drawing.Point(252, 782);
            this.TBregistredbyemp.Name = "TBregistredbyemp";
            this.TBregistredbyemp.Size = new System.Drawing.Size(516, 44);
            this.TBregistredbyemp.TabIndex = 37;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 965);
            this.Controls.Add(this.TBregistredbyemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBcommentemp);
            this.Controls.Add(this.CBworkshiftemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPendemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPstartemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBeventemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBlineemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNadduser);
            this.Controls.Add(this.TBnameemp);
            this.Controls.Add(this.Txnameuser);
            this.Controls.Add(this.Txemailuser);
            this.Controls.Add(this.TBnumberemp);
            this.Controls.Add(this.TxAddUserTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNadduser;
        private System.Windows.Forms.MaskedTextBox TBnameemp;
        private System.Windows.Forms.Label Txnameuser;
        private System.Windows.Forms.Label Txemailuser;
        private System.Windows.Forms.MaskedTextBox TBnumberemp;
        private System.Windows.Forms.Label TxAddUserTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TBlineemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBeventemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPstartemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPendemp;
        private System.Windows.Forms.ComboBox CBworkshiftemp;
        private System.Windows.Forms.TextBox TBcommentemp;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox TBregistredbyemp;
    }
}