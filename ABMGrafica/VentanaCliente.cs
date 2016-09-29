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
    public partial class VentanaCliente : Form
    {
        //Atributo
        Validar v = new Validar();
        private Persona clienteP = new Persona();
        private string direccionArchivo ;	//Agregado
        
        //Constructor
        public VentanaCliente( string ruta)
        {
        	direccionArchivo = ruta;
        	InicializarFichero( direccionArchivo );
            InitializeComponent();
            
        }

        private void InicializarFichero(String fichero){
        	Prestamos = new ListaPrestamos(fichero);
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            clienteP.NumIdentidad = int.Parse(TBNrID.Text);
            clienteP.Nombre = TBNombre.Text;
            clienteP.Apellido = TBApellido.Text;
            clienteP.Telefono = long.Parse(TBTelefono.Text);
            clienteP.Celular = long.Parse(TBCelular.Text);
            (clienteP.Prestamos).NroPrestamo = int.Parse(TBNPrestamos.Text);
            (clienteP.Prestamos).Monto = double.Parse(TBMonto.Text);
            DateTime fecha =  DateTime.Today;
			string a = fecha.Year.ToString();
			string m = fecha.Month.ToString();
			string d = fecha.Day.ToString();
			String f = a+"-"+m+"-"+d;
			(clienteP.Prestamos).Fecha = f;
            if(TBNombre.Enabled == true){
            	if(double.Parse(TBMonto.Text) <= clienteP.MontoMAximo ){
            		if(Prestamos.TopePrestamo(int.Parse(TBNrID.Text))){
            			MessageBox.Show("Supera el numero de prestamos establecido.");
            		}else{
            			Prestamos.agregarRegistro(clienteP);
                		Close();
            		}
            	}else{
            		MessageBox.Show("Ingrese monto menor o igual a : $ "+clienteP.MontoMAximo);
            		TBMonto.ResetText();
            		TBMonto.Focus();
            	}
            	
            }else{
            	String nroIdentidad = TBNrID.Text;
				int i = Prestamos.BuscarReg( int.Parse(nroIdentidad) );
				if(Prestamos.LeerReg(i).MontoMAximo > Prestamos.MontoTotal(int.Parse(nroIdentidad))){
            		if(double.Parse(TBMonto.Text) <= clienteP.MontoMAximo ){
            		if(Prestamos.TopePrestamo(int.Parse(TBNrID.Text))){
            			MessageBox.Show("Supera el numero de prestamos establecido.");
            		}else{
            			Prestamos.agregarRegistro(clienteP);
                		Close();
            		}
				}else{
					double monto = Prestamos.LeerReg(i).MontoMAximo - Prestamos.MontoTotal(int.Parse(nroIdentidad));
					string error = "Supera el tope maximo de prestamo vuelva a ingresar un valor menor o igual a: $ " + monto;
					MessageBox.Show(error);
					TBMonto.ResetText();
					TBMonto.Focus();
				}
            }
        }
		
			Prestamos.CerrarFichero();	//Agregado
        }
		void BCancelarClick(object sender, EventArgs e)
		{
			Prestamos.CerrarFichero();	//Agregado
			Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			String nroIdentidad = TBNrID.Text;
			if(int.Parse(nroIdentidad) <= 0){
				MessageBox.Show("El numero de Identificacion debe de ser mayor que cero");
				TBNrID.ResetText();
				TBNrID.Focus();
			}else{
					int i = Prestamos.BuscarReg( int.Parse(nroIdentidad) );
					if(i>=0){
						if(Prestamos.TopePrestamo(int.Parse(nroIdentidad))){
							MessageBox.Show("Este cliente no puede solicitar mas prestamos");
							TBNrID.ResetText();
							TBNrID.Focus();
						}else{
							clienteP = Prestamos.LeerReg(Prestamos.Nregs - 1);
							int nrPrestamo = (clienteP.Prestamos).NroPrestamo + 1;
							TBNPrestamos.Text = nrPrestamo.ToString();
							habilitarDatosPer(false);
							clienteP = Prestamos.LeerReg(i);
							TBNombre.Text = clienteP.Nombre;
							TBApellido.Text = clienteP.Apellido;
							TBTelefono.Text = clienteP.Telefono.ToString();
							TBCelular.Text = clienteP.Celular.ToString();
						}
					}else{
						habilitarDatosPer(true);
						if(Prestamos.Nregs > 0){
							clienteP = Prestamos.LeerReg(Prestamos.Nregs - 1);
							int nrPrestamo = (clienteP.Prestamos).NroPrestamo + 1;
							TBNPrestamos.Text = nrPrestamo.ToString();
						}else{
							TBNPrestamos.Text = "1";
						}
					}
			}
			
			
		}
		 
		public void habilitarDatosPer(bool e){
			TBNombre.Enabled = e;
			TBApellido.Enabled = e;
			TBTelefono.Enabled = e;
			TBCelular.Enabled = e;
			TBMonto.Enabled = true;
			bAceptar.Enabled = true;
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
