using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABMGrafica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//private static string direccionArchivo = "D:\\Prestamos.bin" ;
				private static string direccionArchivo = "Prestamos.bin" ;
		private Boolean abierto = true ;
		
		private void inicializarFichero(string fichero){
			Prestamos = new ListaPrestamos(fichero);
		}
		
		private void cargarDataGrid(){
			int nregs = Prestamos.NúmeroDeRegs();
			Persona obj;
			this.dataGridView1.Columns.Add("nroPrestamo","NroPrestamo");
			this.dataGridView1.Columns.Add("nroIdentidad","NroIdentidad");
			this.dataGridView1.Columns.Add("nombre","Nombre");
			this.dataGridView1.Columns.Add("apellido","Apellido");
			this.dataGridView1.Columns.Add("telefono","Telefono");
			this.dataGridView1.Columns.Add("celular","Celular");
			this.dataGridView1.Columns.Add("monto","Monto");
			this.dataGridView1.Columns.Add("fecha","Fecha");
			
			for(int reg_i = 0; reg_i< nregs;reg_i++){
				obj = Prestamos.LeerReg(reg_i);
				//if(obj.Teléfono !=0)
					this.dataGridView1.Rows.Add(obj.Prestamos.NroPrestamo,obj.NumIdentidad,obj.Nombre,obj.Apellido,obj.Telefono,obj.Celular,obj.Prestamos.Monto,obj.Prestamos.Fecha);
			}
		}
		
		public void actualizarDataGrid(){
			int nregs = Prestamos.NúmeroDeRegs();
			Persona obj;
			
			dataGridView1.Rows.Clear();
			
			for(int reg_i = 0; reg_i< nregs;reg_i++){
				obj = Prestamos.LeerReg(reg_i);
				this.dataGridView1.Rows.Add(obj.Prestamos.NroPrestamo,obj.NumIdentidad,obj.Nombre,obj.Apellido,obj.Telefono,obj.Celular,obj.Prestamos.Monto,obj.Prestamos.Fecha);
			}
		}
		
		public MainForm()
		{
						
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			inicializarFichero( direccionArchivo );
			InitializeComponent();
			cargarDataGrid();
			//
		
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonActualizarLista (object sender, EventArgs e) {
			if(!abierto) {
				Prestamos.abrirFichero( direccionArchivo ); }
			actualizarDataGrid();
		}
		void ButtonAgregarClick(object sender, EventArgs e)
		{
			Prestamos.CerrarFichero();
			abierto= false;
			
			VentanaCliente agregar = new VentanaCliente( direccionArchivo );
			agregar.Show();
				
		}
		
		void ButtonModificarClick(object sender, EventArgs e)
		{
			Prestamos.CerrarFichero();
			abierto= false;
			
			int numFila = dataGridView1.CurrentRow.Index ;
			int nPrestamo = (int) dataGridView1.Rows[numFila].Cells[0].Value ;
			FormModificar modificar = new FormModificar(direccionArchivo , nPrestamo );
			modificar.Show();
				
		}
		
		void ButtonSalirClick(object sender, EventArgs e)
		{
			Prestamos.CerrarFichero();
			abierto= false;
			this.Close();
			
		}
	}
}