using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMGrafica
{
    public partial class FormModificar : Form
    {
        //Atributo
        Validar v = new Validar();
        private Persona clienteP = new Persona();
		private string direccionArchivo ;
		private int NumFila ;
		private DataGridView dataGrilla ;
		
        //Constructor
        public FormModificar(string ruta , DataGridView data)
        {

        	direccionArchivo = ruta ;
        	dataGrilla = data;
        	int FilaSeleccionada = dataGrilla.CurrentRow.Index ;
        	NumFila = FilaSeleccionada;
        	InicializarFichero( direccionArchivo );
            InitializeComponent();
            mostrarDatos();
            
        }

        private void InicializarFichero(String fichero){
        	Prestamos = new ListaPrestamos(fichero);
        }
        
        private void ButtonGurdarClick(object sender, EventArgs e)
        {
            double montoNuevo, montoTotal, montoViejo, MontoNeto;

            //tomo el registro de la persona que estoy cambiando el monto
            int nroIdentidad = int.Parse(TBNrID.Text);
            int i = Prestamos.BuscarReg(nroIdentidad);//me devuelve el numero de registro
            clienteP = Prestamos.LeerReg(i);
            montoNuevo =double.Parse(TBMonto.Text);

            if (clienteP.Prestamos.FechaAutorizacion == "aaaa-mm-dd")
            {
                montoTotal = Prestamos.MontoTotal(nroIdentidad);
                montoViejo = clienteP.Prestamos.Monto;//aqui tengo el monto a modificar
                MontoNeto = (montoTotal - montoViejo) + montoNuevo;
                if (MontoNeto <= 1000)
                   {/*lo guarda en el fichero*/
                    clienteP.NumIdentidad = int.Parse(TBNrID.Text);
                    clienteP.Nombre = TBNombre.Text;
                    clienteP.Apellido = TBApellido.Text;
                    clienteP.Telefono = long.Parse(TBTelefono.Text);
                    clienteP.Celular = long.Parse(TBCelular.Text);
                    (clienteP.Prestamos).Monto = double.Parse(TBMonto.Text);
                    string fecha = clienteP.Prestamos.Fecha;
                    Prestamos.EscribirRegistro(i, clienteP);
                }
                else
                { /*ingrese otro monto*/}
            }
            else
            { MessageBox.Show("Ya fue Autorizado el Prestamo, no puede cambiar el monto"); }
            Close();
			Prestamos.CerrarFichero();	// NO BORRAR
        }
		void ButtonCancelarClick(object sender, EventArgs e)
		{
			Prestamos.CerrarFichero();
			Close();
		}
		private void mostrarDatos ()
		{
			int nroIdentidad = obtenerNroIdentidadGrilla();
			int i = Prestamos.BuscarReg(nroIdentidad);
			
			if( Prestamos.TopePrestamo(nroIdentidad) ){
				MessageBox.Show("Este cliente no puede solicitar mas prestamos");
				TBNrID.ResetText();
				TBNrID.Focus();
			}else{
				clienteP = Prestamos.LeerReg(Prestamos.Nregs - 1);
				TBNPrestamos.Text = ""+(NumFila+1);
				habilitarDatosPer(false);
				clienteP = Prestamos.LeerReg(i);
				TBNrID.Text = clienteP.NumIdentidad.ToString();
				TBNombre.Text = clienteP.Nombre;
				TBApellido.Text = clienteP.Apellido;
				TBTelefono.Text = clienteP.Telefono.ToString();
				TBCelular.Text = clienteP.Celular.ToString();
			}
		}
		
		public string obtenerValorCeldaGrilla (int fila , int col){
			return (string ) dataGrilla.Rows[fila].Cells[col].Value ;
		}
		public int obtenerNroIdentidadGrilla (){
			return (int) dataGrilla.Rows[NumFila].Cells[1].Value ;
		}
		
		 
		public void habilitarDatosPer(bool e){
			TBNrID.Enabled = e ;
			TBNombre.Enabled = e;
			TBApellido.Enabled = e;
			TBTelefono.Enabled = e;
			TBCelular.Enabled = e;
			TBMonto.Enabled = true;
			btnGuardar.Enabled = true;
		}
		void TBNrIDKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloNumeros(e);
		}
		void TBNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloLetras(e);
		}
		void TBApellidoKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloLetras(e);
		}
		void TBTelefonoKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloNumeros(e);
		}
		void TBCelularKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloNumeros(e);
		}
		void TBMontoKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloNumerosDecimales(e);
		}
       
    }
}

