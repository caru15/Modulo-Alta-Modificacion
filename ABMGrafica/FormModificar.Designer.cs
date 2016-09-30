/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 28/09/2016
 * Time: 11:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ABMGrafica
{
	partial class FormModificar
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private static ListaPrestamos Prestamos;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBCelular = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBNrID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TBCuotas = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelCuotas = new System.Windows.Forms.Label();
            this.TBNPrestamos = new System.Windows.Forms.TextBox();
            this.TBMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.TBCelular);
            this.groupBox1.Controls.Add(this.TBTelefono);
            this.groupBox1.Controls.Add(this.TBApellido);
            this.groupBox1.Controls.Add(this.TBNombre);
            this.groupBox1.Controls.Add(this.TBNrID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // TBCelular
            // 
            this.TBCelular.Enabled = false;
            this.TBCelular.Location = new System.Drawing.Point(87, 121);
            this.TBCelular.Name = "TBCelular";
            this.TBCelular.Size = new System.Drawing.Size(199, 20);
            this.TBCelular.TabIndex = 9;
            this.TBCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCelularKeyPress);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Enabled = false;
            this.TBTelefono.Location = new System.Drawing.Point(87, 95);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(199, 20);
            this.TBTelefono.TabIndex = 8;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefonoKeyPress);
            // 
            // TBApellido
            // 
            this.TBApellido.Enabled = false;
            this.TBApellido.Location = new System.Drawing.Point(87, 69);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(199, 20);
            this.TBApellido.TabIndex = 7;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellidoKeyPress);
            // 
            // TBNombre
            // 
            this.TBNombre.Enabled = false;
            this.TBNombre.Location = new System.Drawing.Point(87, 43);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(199, 20);
            this.TBNombre.TabIndex = 6;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombreKeyPress);
            // 
            // TBNrID
            // 
            this.TBNrID.Location = new System.Drawing.Point(87, 19);
            this.TBNrID.Name = "TBNrID";
            this.TBNrID.Size = new System.Drawing.Size(199, 20);
            this.TBNrID.TabIndex = 5;
            this.TBNrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNrIDKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. Identidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.TBCuotas);
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.Controls.Add(this.labelFecha);
            this.groupBox2.Controls.Add(this.labelCuotas);
            this.groupBox2.Controls.Add(this.TBNPrestamos);
            this.groupBox2.Controls.Add(this.TBMonto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(9, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Prestamos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            //this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1.ValueChanged);
            // 
            // TBCuotas
            // 
            this.TBCuotas.Location = new System.Drawing.Point(99, 73);
            this.TBCuotas.Name = "TBCuotas";
            this.TBCuotas.Size = new System.Drawing.Size(139, 20);
            this.TBCuotas.TabIndex = 16;
            this.TBCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCuotasKeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(255, 45);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(31, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.ButtonOKClick);
            // 
            // labelFecha
            // 
            this.labelFecha.Location = new System.Drawing.Point(6, 99);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(95, 20);
            this.labelFecha.TabIndex = 15;
            this.labelFecha.Text = "Fecha de Autoriz:";
            // 
            // labelCuotas
            // 
            this.labelCuotas.Location = new System.Drawing.Point(3, 72);
            this.labelCuotas.Name = "labelCuotas";
            this.labelCuotas.Size = new System.Drawing.Size(90, 20);
            this.labelCuotas.TabIndex = 14;
            this.labelCuotas.Text = "Cantidad Cuotas";
            // 
            // TBNPrestamos
            // 
            this.TBNPrestamos.Enabled = false;
            this.TBNPrestamos.Location = new System.Drawing.Point(99, 19);
            this.TBNPrestamos.Name = "TBNPrestamos";
            this.TBNPrestamos.Size = new System.Drawing.Size(139, 20);
            this.TBNPrestamos.TabIndex = 10;
            // 
            // TBMonto
            // 
            this.TBMonto.Enabled = false;
            this.TBMonto.Location = new System.Drawing.Point(99, 45);
            this.TBMonto.Name = "TBMonto";
            this.TBMonto.Size = new System.Drawing.Size(139, 20);
            this.TBMonto.TabIndex = 11;
            this.TBMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMontoKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° de Prestamo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto: $";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(226, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 328);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(348, 363);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBCelular;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBNrID;
        private System.Windows.Forms.TextBox TBNPrestamos;
        private System.Windows.Forms.TextBox TBMonto;
        private System.Windows.Forms.TextBox TBCuotas;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelCuotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}
