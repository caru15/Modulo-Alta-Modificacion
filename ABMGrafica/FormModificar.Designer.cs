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
        	this.TBNPrestamos = new System.Windows.Forms.TextBox();
        	this.TBMonto = new System.Windows.Forms.TextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.btnCancelar = new System.Windows.Forms.Button();
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
        	this.groupBox1.Size = new System.Drawing.Size(264, 166);
        	this.groupBox1.TabIndex = 0;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Datos Personales";
        	// 
        	// TBCelular
        	// 
        	this.TBCelular.Enabled = false;
        	this.TBCelular.Location = new System.Drawing.Point(87, 121);
        	this.TBCelular.Name = "TBCelular";
        	this.TBCelular.Size = new System.Drawing.Size(139, 20);
        	this.TBCelular.TabIndex = 9;
        	this.TBCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCelularKeyPress);
        	// 
        	// TBTelefono
        	// 
        	this.TBTelefono.Enabled = false;
        	this.TBTelefono.Location = new System.Drawing.Point(87, 95);
        	this.TBTelefono.Name = "TBTelefono";
        	this.TBTelefono.Size = new System.Drawing.Size(139, 20);
        	this.TBTelefono.TabIndex = 8;
        	this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefonoKeyPress);
        	// 
        	// TBApellido
        	// 
        	this.TBApellido.Enabled = false;
        	this.TBApellido.Location = new System.Drawing.Point(87, 69);
        	this.TBApellido.Name = "TBApellido";
        	this.TBApellido.Size = new System.Drawing.Size(139, 20);
        	this.TBApellido.TabIndex = 7;
        	this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellidoKeyPress);
        	// 
        	// TBNombre
        	// 
        	this.TBNombre.Enabled = false;
        	this.TBNombre.Location = new System.Drawing.Point(87, 43);
        	this.TBNombre.Name = "TBNombre";
        	this.TBNombre.Size = new System.Drawing.Size(139, 20);
        	this.TBNombre.TabIndex = 6;
        	this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombreKeyPress);
        	// 
        	// TBNrID
        	// 
        	this.TBNrID.Location = new System.Drawing.Point(87, 19);
        	this.TBNrID.Name = "TBNrID";
        	this.TBNrID.Size = new System.Drawing.Size(139, 20);
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
        	this.groupBox2.Controls.Add(this.TBNPrestamos);
        	this.groupBox2.Controls.Add(this.TBMonto);
        	this.groupBox2.Controls.Add(this.label6);
        	this.groupBox2.Controls.Add(this.label7);
        	this.groupBox2.Location = new System.Drawing.Point(9, 181);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(263, 81);
        	this.groupBox2.TabIndex = 1;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Datos Prestamos";
        	// 
        	// TBNPrestamos
        	// 
        	this.TBNPrestamos.Enabled = false;
        	this.TBNPrestamos.Location = new System.Drawing.Point(87, 26);
        	this.TBNPrestamos.Name = "TBNPrestamos";
        	this.TBNPrestamos.Size = new System.Drawing.Size(139, 20);
        	this.TBNPrestamos.TabIndex = 10;
        	// 
        	// TBMonto
        	// 
        	this.TBMonto.Enabled = false;
        	this.TBMonto.Location = new System.Drawing.Point(87, 49);
        	this.TBMonto.Name = "TBMonto";
        	this.TBMonto.Size = new System.Drawing.Size(139, 20);
        	this.TBMonto.TabIndex = 11;
        	this.TBMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMontoKeyPress);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(6, 33);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(84, 13);
        	this.label6.TabIndex = 5;
        	this.label6.Text = "N° de Prestamo:";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(41, 52);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(49, 13);
        	this.label7.TabIndex = 6;
        	this.label7.Text = "Monto: $";
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Enabled = false;
        	this.btnGuardar.Location = new System.Drawing.Point(125, 277);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(66, 23);
        	this.btnGuardar.TabIndex = 2;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.ButtonGurdarClick);
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(197, 277);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(75, 23);
        	this.btnCancelar.TabIndex = 3;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
        	// 
        	// FormModificar
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoSize = true;
        	this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.ClientSize = new System.Drawing.Size(284, 302);
        	this.ControlBox = false;
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
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
        private System.Windows.Forms.Button btnGuardar;
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
	}
}
