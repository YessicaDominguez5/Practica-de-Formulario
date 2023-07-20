namespace Formulario
{
    partial class Form1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxHambre = new System.Windows.Forms.CheckBox();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonSquib = new System.Windows.Forms.RadioButton();
            this.radioButtonMuggle = new System.Windows.Forms.RadioButton();
            this.radioButtonWizard = new System.Windows.Forms.RadioButton();
            this.labelLibro = new System.Windows.Forms.Label();
            this.comboBoxLibroHP = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTitulo.Font = new System.Drawing.Font("Californian FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(31, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(64, 27);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Perfil";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(33, 78);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(98, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre y Apellido: ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(137, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(33, 115);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(114, 13);
            this.labelFechaNacimiento.TabIndex = 3;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // checkBoxHambre
            // 
            this.checkBoxHambre.AutoSize = true;
            this.checkBoxHambre.Location = new System.Drawing.Point(36, 151);
            this.checkBoxHambre.Name = "checkBoxHambre";
            this.checkBoxHambre.Size = new System.Drawing.Size(106, 17);
            this.checkBoxHambre.TabIndex = 3;
            this.checkBoxHambre.Text = "¿Tenes hambre?";
            this.checkBoxHambre.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTipo.Controls.Add(this.radioButtonSquib);
            this.groupBoxTipo.Controls.Add(this.radioButtonMuggle);
            this.groupBoxTipo.Controls.Add(this.radioButtonWizard);
            this.groupBoxTipo.Location = new System.Drawing.Point(72, 212);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(316, 64);
            this.groupBoxTipo.TabIndex = 4;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Seleccione tipo";
            // 
            // radioButtonSquib
            // 
            this.radioButtonSquib.AutoSize = true;
            this.radioButtonSquib.Location = new System.Drawing.Point(195, 25);
            this.radioButtonSquib.Name = "radioButtonSquib";
            this.radioButtonSquib.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSquib.TabIndex = 2;
            this.radioButtonSquib.TabStop = true;
            this.radioButtonSquib.Text = "Squib";
            this.radioButtonSquib.UseVisualStyleBackColor = true;
            // 
            // radioButtonMuggle
            // 
            this.radioButtonMuggle.AutoSize = true;
            this.radioButtonMuggle.Location = new System.Drawing.Point(114, 25);
            this.radioButtonMuggle.Name = "radioButtonMuggle";
            this.radioButtonMuggle.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMuggle.TabIndex = 1;
            this.radioButtonMuggle.TabStop = true;
            this.radioButtonMuggle.Text = "Muggle";
            this.radioButtonMuggle.UseVisualStyleBackColor = true;
            // 
            // radioButtonWizard
            // 
            this.radioButtonWizard.AutoSize = true;
            this.radioButtonWizard.Location = new System.Drawing.Point(28, 25);
            this.radioButtonWizard.Name = "radioButtonWizard";
            this.radioButtonWizard.Size = new System.Drawing.Size(58, 17);
            this.radioButtonWizard.TabIndex = 0;
            this.radioButtonWizard.TabStop = true;
            this.radioButtonWizard.Text = "Wizard";
            this.radioButtonWizard.UseVisualStyleBackColor = true;
            // 
            // labelLibro
            // 
            this.labelLibro.AutoSize = true;
            this.labelLibro.Location = new System.Drawing.Point(16, 299);
            this.labelLibro.Name = "labelLibro";
            this.labelLibro.Size = new System.Drawing.Size(148, 13);
            this.labelLibro.TabIndex = 8;
            this.labelLibro.Text = "Libro Favorito de Harry Potter:";
            // 
            // comboBoxLibroHP
            // 
            this.comboBoxLibroHP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLibroHP.FormattingEnabled = true;
            this.comboBoxLibroHP.Location = new System.Drawing.Point(72, 330);
            this.comboBoxLibroHP.Name = "comboBoxLibroHP";
            this.comboBoxLibroHP.Size = new System.Drawing.Size(316, 21);
            this.comboBoxLibroHP.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAceptar.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonAceptar.FlatAppearance.BorderSize = 2;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAceptar.Location = new System.Drawing.Point(137, 478);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(142, 57);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "&Aceptar";
            this.buttonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(464, 635);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxLibroHP);
            this.Controls.Add(this.labelLibro);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.checkBoxHambre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 674);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 674);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxHambre;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonSquib;
        private System.Windows.Forms.RadioButton radioButtonMuggle;
        private System.Windows.Forms.RadioButton radioButtonWizard;
        private System.Windows.Forms.Label labelLibro;
        private System.Windows.Forms.ComboBox comboBoxLibroHP;
        private System.Windows.Forms.Button buttonAceptar;
    }
}

