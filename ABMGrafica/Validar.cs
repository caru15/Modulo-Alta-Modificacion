using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABMGrafica
{
	/// <summary>
	/// Description of Validar.
	/// </summary>
	public class Validar
	{
			
			public void soloLetras(KeyPressEventArgs e)
    	    {
    	        try
         		   {
        		      if (Char.IsLetter(e.KeyChar))
             		   {
           	     	    e.Handled = false;
              		  }
              		  else if (Char.IsControl(e.KeyChar))
                		{
                   		 e.Handled = false;
                		}
                	else if (Char.IsSeparator(e.KeyChar))
                	{
                	   	 e.Handled = false;
                	}
               		 else
                	{
               	     e.Handled = true;
               		 }
            	}
            	catch (Exception ex)
            	{

            	}
        	}

      	  public void soloNumeros(KeyPressEventArgs e)
    	    {
     	       try
     	       {
         	       if (Char.IsNumber(e.KeyChar))
           	     {
            	        e.Handled = false;
             	   }
            	    else if (Char.IsControl(e.KeyChar))
            	    {
             	       e.Handled = false;
             	   }
             	   else
             	   {
               	     e.Handled = true;
               	 }
           	 }
           	 catch (Exception ex)
           	 {

          	  }
       	 }	
			
      	    public void soloNumerosDecimales(KeyPressEventArgs e)
    	    {
     	       try
     	       {
         	       if (Char.IsNumber(e.KeyChar))
           	     {
            	        e.Handled = false;
             	   }
            	    else if (Char.IsControl(e.KeyChar))
            	    {
             	       e.Handled = false;
            	    }else if ((char)e.KeyChar == ',')
            	    {
             	       e.Handled = false;
             	   }
             	   else
             	   {
               	     e.Handled = true;
               	 }
           	 }
           	 catch (Exception ex)
           	 {

          	  }
       	 }	
		
	}
}
