using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMGrafica
{

    public class Persona
    {
    	private string vald = "12345678901234567890";
    	//Atributos
        private int numIdentidad;
       	private string nombre;
        private string apellido;
        //private string apellido2;
        private Solicitud soli = new Solicitud();//aqui estan las cuotas las fechas de autorizacio  y nro de prestamo
        private long telefono;
        private long celular;
        private double montoMaximo = 1000.00;
        private int topeMaximo = 5;
        //Constructores
        public Persona()
        {
        	nombre = vald;
        	apellido = vald;
        }
        public Persona(string nom,string apell,int docUni,long tel,long cel)
        {
        	nombre = nom;
            apellido = apell;
            //apellido2 = ap2;
            numIdentidad = docUni;
            telefono = tel;
            celular = cel;
        }
		
        public Persona(int numPrestamo,int docUni,string nom,string apell,long tel,long cel,double monto,string fecha)
        {
            nombre = nom;
            apellido = apell;
            //apellido2 = ap2;
            numIdentidad = docUni;
            telefono = tel;
            celular = cel;
            soli.NroPrestamo = numPrestamo;
            soli.Fecha = fecha;
            soli.Monto = monto;
        }
        //Metodos getters y setters
        public int TopeMaximo{
        	get{return topeMaximo;}
        	set{topeMaximo = value;}
        }
        public double MontoMAximo{
        	get{return montoMaximo;}
        	set{montoMaximo = value;}
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        /*public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }*/
        public int NumIdentidad
        {
            get { return numIdentidad; }
            set { numIdentidad = value; }
        }
        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public long Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public Solicitud Prestamos{
        	get{return soli;}
        }
  		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return nombre.Length*2 + apellido.Length*2 + 4 + 8 + 8 + soli.Tamaño; }
  		}
    }
}
