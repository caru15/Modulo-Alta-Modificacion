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
		private int posicionRegistroMoficar ;
        private int CantidadCuotas;
        string[] cuotas = new string[5];

        //Constructor
        public FormModificar(string ruta , int nroPrestamo)
        {

        	direccionArchivo = ruta ;
        	InicializarFichero( direccionArchivo );
            InitializeComponent();
            mostrarDatos( nroPrestamo );
            
        }

        private void InicializarFichero(String fichero){
        	Prestamos = new ListaPrestamos(fichero);
        }
        
        private void ButtonOKClick(object sender, EventArgs e)
        {
            double montoNuevo, montoTotal, montoViejo, MontoNeto;

            //tomo el registro de la persona que estoy cambiando el monto
            int nroPrestamo = int.Parse(TBNPrestamos.Text);
            posicionRegistroMoficar = Prestamos.BuscarPrestamoReg(nroPrestamo);//me devuelve el numero de registro
            clienteP = Prestamos.LeerReg( posicionRegistroMoficar );
            montoNuevo =double.Parse(TBMonto.Text);

            if (clienteP.Prestamos.FechaAutorizacion == "aaaa-mm-dd")
            {
                montoTotal = Prestamos.MontoTotal(clienteP.NumIdentidad);
                montoViejo = clienteP.Prestamos.Monto;//aqui tengo el monto a modificar
                MontoNeto = (montoTotal - montoViejo) + montoNuevo;
                if (MontoNeto <= clienteP.MontoMAximo)
                {
                	/*lo guarda en el fichero*/
                    clienteP.NumIdentidad = int.Parse(TBNrID.Text);
                    clienteP.Nombre = TBNombre.Text;
                    clienteP.Apellido = TBApellido.Text;
                    clienteP.Telefono = long.Parse(TBTelefono.Text);
                    clienteP.Celular = long.Parse(TBCelular.Text);
                    (clienteP.Prestamos).Monto = double.Parse(TBMonto.Text);
                    string fecha = clienteP.Prestamos.Fecha;
					
					TBMonto.Enabled = false;
					TBCuotas.Enabled = true ;
					dateTimePicker1.Enabled = true ;
					btnOK.Enabled = false;
					btnGuardar.Enabled = true;
					
                }
                else
                {
                	MessageBox.Show("El monto Supera al Monto Maximo Ingrese Otro");
                }
            }
            else
            { 
            	MessageBox.Show("Ya fue Autorizado el Prestamo, no puede cambiar el monto");
            	Prestamos.CerrarFichero();	// NO BORRAR
            	Close();
            }
        }
        private void ButtonGuardarClick(object sender, EventArgs e)
        {
            AsignarFechaCuotas();
        	//Prestamos.EscribirRegistro( posicionRegistroMoficar, clienteP);
        	Prestamos.CerrarFichero();
        	Close();
        	
        }
        //este metodo me duvelve el monto  a pagar por cada cuota
        public double MontoCuotas() {

            CantidadCuotas = int.Parse(TBCuotas.Text);
             double Monto=double.Parse(TBMonto.Text);
            double MontoCadaCuota = Monto / CantidadCuotas;
            return MontoCadaCuota;
        }
        //metodo que asigna Fecha de pago de cada una de la cuotas
        public void AsignarFechaCuotas() 
        {
            string[] f;
            int nroPrestamo = int.Parse(TBNPrestamos.Text);
            posicionRegistroMoficar = Prestamos.BuscarPrestamoReg(nroPrestamo);//me devuelve el numero de registro
            clienteP = Prestamos.LeerReg(posicionRegistroMoficar);
            //string Fa = clienteP.Prestamos.FechaAutorizacion;
            string Fa = dateTimePicker1.Text;
           
            //DateTime F = DateTime.Parse(Fa);
            //Fa= date.ToString("yyyy-MM-dd");
            f = Fa.Split('-');                            //cary no lo separa la fecha xq guarda "viernes,30 de septiembre 2016"
            int anio = int.Parse(f[0]);
            int mes = int.Parse(f[1]);
            int dia = int.Parse(f[2]);
            //int anio = F.Year;
            //int mes = F.Month;
            //int dia = F.Day;
                //Fa es la fecha de autorizacion
            int cc = CantidadCuotas;
            int i = 0;
            while (cc > 0) { 
                if (mes == 12) 
                { 
                    cuotas[i] = (anio + 1).ToString() + "-" + "01" + "-"+dia;
                    mes = 1; anio = anio + 1;i++;
                }
                else { cuotas[i] = anio.ToString()+ "-" + (mes + 1).ToString() + "-" +dia;
                    mes = mes + 1; i++;
                }
                cc--;
            }
            //LLAMAR AQUI EL METODO QUE HACE GIME//
            ModificarFechaCoutaFinSemana();
            GuardaFechas(clienteP);
            Prestamos.EscribirRegistro(posicionRegistroMoficar, clienteP);
        }
        public void GuardaFechas(Persona obj) {

           // for (int i = 0; i < 6; i++) 
            //{
            //    cuotas[i] = "aaaa-mm-dd";
            //}
            
            obj.Prestamos.Cuotacero = cuotas[0];
            obj.Prestamos.Cuotauno = cuotas[1];
            obj.Prestamos.Cuotados = cuotas[2];
            obj.Prestamos.Cuotatres = cuotas[3];
            obj.Prestamos.Cuotacuatro = cuotas[4];
            obj.Prestamos.Cuotacinco = cuotas[5];
        }
        public int DiaSemana(string t) // obtiene el dia de la semana
        {
            DateTime da = DateTime.Parse(t);
            int dateValue = (int)(da.DayOfWeek);
            return dateValue;    
        }

        public void ModificarFechaCoutaFinSemana() //Modifica las fechas de cuotas si caen un fin de semana
        {
            
            for (int i = 0; i < cuotas.Length; i++)
            {
                int resp = DiaSemana(cuotas[i]);
                string [] f = cuotas[i].Split('-');
                int anio = int.Parse(f[0]);
                int mes = int.Parse(f[1]);
                int dia = int.Parse(f[2]);
                if (resp==7)
                {
                    cuotas[i] = f[0]+ "-" + f[1] +"-"+ (dia+1).ToString();
                }
                else if(resp==6)
                {
                    cuotas[i] = f[0]+ "-" + f[1] +"-"+ (dia+2).ToString();
                }
                else
                {
                    cuotas[i] = cuotas[i];       
                }
            }
        }
        
        void ButtonCancelarClick(object sender, EventArgs e)
		{
			Prestamos.CerrarFichero();
			Close();
		}
		private void mostrarDatos (int nroPrestamo)
		{
			int i = Prestamos.BuscarPrestamoReg(nroPrestamo);//me devuelve el numero de registro
            clienteP = Prestamos.LeerReg(i);/*lo guarda en el fichero*/
				
            habilitarDatosPer(false);
            TBNrID.Text = clienteP.NumIdentidad.ToString();
            TBNombre.Text = clienteP.Nombre;
            TBApellido.Text = clienteP.Apellido;
            TBTelefono.Text = clienteP.Telefono.ToString();
            TBCelular.Text = clienteP.Celular.ToString();
            TBNPrestamos.Text = ""+nroPrestamo;
			
		}
		
		/*
		public string obtenerValorCeldaGrilla (int fila , int col){
			return (string ) dataGrilla.Rows[fila].Cells[col].Value ;
		}
		public int obtenerNroIdentidadGrilla (){
			return (int) dataGrilla.Rows[NumFila].Cells[1].Value ;
		}
		*/
		 
		public void habilitarDatosPer(bool e){
			TBNrID.Enabled = e ;
			TBNombre.Enabled = e;
			TBApellido.Enabled = e;
			TBTelefono.Enabled = e;
			TBCelular.Enabled = e;
			TBMonto.Enabled = true;
			TBCuotas.Enabled = e ;
			dateTimePicker1.Enabled = e ;
			btnOK.Enabled = true;
			btnGuardar.Enabled = e ;
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
		void TBCuotasKeyPress(object sender, KeyPressEventArgs e)
		{
			v.soloNumeros(e);
		}       
    }
}

