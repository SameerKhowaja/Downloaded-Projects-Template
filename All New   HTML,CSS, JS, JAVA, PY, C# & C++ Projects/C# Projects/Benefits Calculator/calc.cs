// Autor: Brayan Kelly Balbune
// Date: 27/5/2016
// project name: Benefit Calculator.cs


using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloLearn
{
    class Prestacion
    {   
        public decimal SumatoriaSalarios { get; set; } 
        public decimal SalarioPromedioMensual { get; set; }
        public decimal SalarioPromedioDiario { get; set; }
        private List<decimal> salarios = new List<decimal>();
        public DateTime FechaInicio { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal SalarioNavidad { get; set; }
        public decimal Cesantia { get; set; }
        
        public Prestacion()
        {
            Console.WriteLine( "Bienvenido a Calculadora de prestaciones" );
        }
        
        
        // Metodo que permite la entrada de los datos
        public void InputDatos()
        {   
            
            decimal inputSueldo = 0;
            decimal inputComision = 0;
            bool error = true;
            
            // captura las fechas
            while( error )
            {
                try
                {   
                    Console.WriteLine( "Digite la fecha de entrada formato dia/mes/año: " );
                    FechaInicio = Convert.ToDateTime( Console.ReadLine() );
                    Console.WriteLine( "Digite la fecha de salida formato dia/mes/año: " );
                    FechaSalida = Convert.ToDateTime( Console.ReadLine() );
                    
                    throw new System.ArgumentException("Fecha no valida vuelva a intente", "fecha");
                    error = false;
                    
                }catch(Exception e )
                {
                    Console.WriteLine( e.Message );

                }
            }
            
            // captura el sueldo
            for ( int numeroSueldo = 1; numeroSueldo <= 12; numeroSueldo++ )
            {
               Console.WriteLine( "Digite su saldo" );
                while( error )
                {
                    try
                    {
                       inputSueldo = Convert.ToDecimal( Console.ReadLine() );
                       if ( inputSueldo <= 0 )
                          throw new System.ArgumentException("Error sueldo no valido", "saldo" );
                       error = false;
                      
                    }
                   catch(Exception e )
                   {   
                       Console.WriteLine( e.Message );
                   }   
                }
                salarios.Add( inputSueldo );
            }
        }
        
        
        public int CalcularMesesDeDiferencia()
        {
            return Math.Abs((FechaInicio.Month - FechaSalida.Month) + 12 * (FechaInicio.Year - FechaSalida.Year));
        }
        
        public double CalcularDiasDeDiferencia()
        {
            TimeSpan diferencia;
            diferencia = FechaSalida - FechaInicio;
 
             return  diferencia.Days;
        }
        
        public void CalcularDatos()
        {   
            // calcula el promedio total
           salarios.ForEach(  delegate( decimal sueldo )
            {
                SumatoriaSalarios += sueldo;
            });
            
            SalarioPromedioMensual = SumatoriaSalarios / 12;
            SalarioPromedioDiario = SalarioPromedioMensual / 23.83M  ;
            SalarioNavidad =  SalarioPromedioMensual * ( decimal ) CalcularMesesDeDiferencia()  ;
            Cesantia = SalarioPromedioMensual * ( decimal ) CalcularDiasDeDiferencia() / 360 ;
            
            
        }
        
        public void MostrarDatos()
        {
            Console.WriteLine( "Sumatoria Salarios: {0:C}\nSalarioPromedioMensual: {1:C}",
                SumatoriaSalarios, SalarioPromedioMensual );
            Console.WriteLine( "Salario Promedio Diario: {0:C}\nSalario Navidad{1:C}",
                SalarioPromedioDiario, SalarioNavidad );
            Console.WriteLine( "Cesantia{0:C}: ", Cesantia );
        }
        
    }
     
	class Program
	{
		static void Main(string[] args)
		{
			Prestacion prestacion = new Prestacion();
			prestacion.InputDatos();
			prestacion.CalcularDatos();
			prestacion.MostrarDatos();
			
		}
	}
}
