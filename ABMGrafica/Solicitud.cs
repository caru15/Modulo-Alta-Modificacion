using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMGrafica
{
   public class Solicitud
    {
   		private string vald = "aaaa-mm-dd";
        //Atributos
        private int nroPrestamo;
        private double monto;
        private string Cuota0;
        private string Cuota1;
        private string Cuota2;
        private string Cuota3;
        private string Cuota4;
        private string Cuota5;
        private string fechaAutorizacion ;
        private string fechaEntregaPrestamo;
		private string fecha;
        //Constructor
        public Solicitud()
        {
        	Cuota0 = vald;
        	Cuota1 = vald;
        	Cuota2 = vald;
        	Cuota3 = vald;
        	Cuota4 = vald;
        	Cuota5 = vald;
        	fecha = vald;
        	fechaAutorizacion = vald;
        	fechaEntregaPrestamo = vald;
        }
        //Getters and setters
        public double Monto{
        	get{return monto;}
        	set{monto = value;}
        }
        public String Cuotacero{
        	get{return Cuota0;}
        	set{Cuota0 = value;}
        }
        
        public String Cuotauno{
        	get{return Cuota1;}
        	set{Cuota1 = value;}
        }
        public String Cuotados{
        	get{return Cuota2;}
        	set{Cuota2 = value;}
        }
        public String Cuotatres{
        	get{return Cuota3;}
        	set{Cuota3 = value;}
        }
        public String Cuotacuatro{
        	get{return Cuota4;}
        	set{Cuota4 = value;}
        }
        public String Cuotacinco{
        	get{return Cuota5;}
        	set{Cuota5 = value;}
        }
        public int NroPrestamo
        {
            get { return nroPrestamo; }
            set { nroPrestamo = value; }
        }
        
        public double ValorPrestamo
        {
            get { return monto; }
            set { monto = value; }
        }
        public String Fecha{
        	get{return fecha;}
        	set{fecha = value;}
        }
        public string FechaAutorizacion
        {
            get { return fechaAutorizacion; }
            set { fechaAutorizacion = value; }
        }
        public string FechaEntregaPrestamo
        {
            get { return fechaEntregaPrestamo; }
            set { fechaEntregaPrestamo = value; }
        }
       
  		public int Tamaño
  		{	
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + 16 + fecha.Length*2 + fechaAutorizacion.Length*2 + fechaEntregaPrestamo.Length*2 +
	    				Cuota0.Length*2 + Cuota1.Length*2 + Cuota2.Length*2 + Cuota3.Length*2 + Cuota4.Length*2 + 
    					Cuota5.Length*2; }
  		}
    }
}

/*
  Número de Préstamo (numérico entero)
 Solicitante del préstamo (Persona). Se requiere únicamente: Nro. De identidad, Primer
Nombre, Primer y Segundo Apellido, teléfono de casa y teléfono móvil.
 Valor del préstamo (numérico con decimales)
 Fechas de pago de las cuotas (arreglo de un máximo de 6 fechas, se asume que el
plazo máximo de pago son 6 meses).
 Fecha de autorización del préstamo.
 Fecha tentativa de entrega del préstamo. 

     */
