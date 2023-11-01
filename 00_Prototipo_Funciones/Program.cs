using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _00_Prototipo_Funciones
{
    internal class Program
    {
        public static string val1 = " ", val2 = " ";
        public static float resultado = 0, num1 = 0, num2 = 0;

        //Oportunidades de mejora al terminar prototip en funciones.
        //El uso de datos double es preferible sobre float debido a que las funciones de math utilizan Double en vez de float.
        //El uso de double podria reducir la cantidad de conversiones.
        static void Main(string[] args)
        {
            CalculadoraPrototipo();
        }

        static void CalculadoraPrototipo()
        {
            bool estado = true;
            while(estado)
            {
                Console.WriteLine("--Calculadora Prototipo de Funciones--");
                Console.WriteLine("1. Factorial.");
                Console.WriteLine("2. Elevar al cuadrado.");
                Console.WriteLine("3. Elevar X a Y.");
                Console.WriteLine("4. Elevar 10 a X.");
                Console.WriteLine("5. Logaritmo.");
                Console.WriteLine("6. Raiz Cuadrada elevada al cuadrado.");
                Console.WriteLine("7. Salida.");
                Console.WriteLine("Seleccion: ");
                int.TryParse(Console.ReadLine(), out int opc);
                if (opc == 1) { Factorial(); }
                else if (opc == 2) { ElevarCuadrado(); }
                else if (opc == 3) { ElevarXY(); }
                else if (opc == 4) { Elevar10aX();  }
                else if (opc ==5) { Logaritmo(); }
                else if (opc == 6) { RaizCuadrada(); }
                else if (opc == 7) { estado = false; }
                else { Console.WriteLine("Opcion invalida"); }
            }
        }

        static void Factorial()
        {
            //ENFOQUE: VALIDAR SI ES NECESARIO PROCESAR NUMEROS NO NATURALES
            Console.WriteLine("--Calcular Factorial--");
            Console.WriteLine("Ingrese el valor a factorizar: ");
            val1 = Console.ReadLine();
            num1 = float.Parse(val1);
            float factorial = num1;
            float i = factorial;
            float acumulador = 0;
            if( factorial == 1)
            {
                Console.WriteLine($"Resultado: {factorial}");
            }
            else if(factorial == 0){ Console.WriteLine("Operacion no posible ya que el resultado de la multiplicacion por 0 es 0."); }
            else if(factorial > 0)
            {
                while (i != 1)
                {
                    if(factorial == i)
                    {
                        i = i - 1;
                        acumulador = factorial * i;
                        Console.WriteLine("==");
                        Console.WriteLine($"{factorial}x{i}:{factorial*i}");
                        Console.WriteLine($"Acumulado: {acumulador}");
                        Console.WriteLine("==");
                    }
                    else
                    {
                        i = i - 1;
                        acumulador = acumulador * i;
                        Console.WriteLine("==");
                        Console.WriteLine($"{factorial}x{i}:{factorial * i}");
                        Console.WriteLine($"Acumulado: {acumulador}");
                        Console.WriteLine("==");
                    }
                }
                Console.WriteLine($"Resultado: {acumulador}");
                
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();
            //--Observaciones
            //Se debe de calcular con un metodo especifico ya que no tiene libreria propia
            //en visual studio al menos de utilizar Math.NET que es exterior.
            //NOTA NUMEROS NEGATIVOS: se podria dar un mensaje de error o simplemente convertir el numero a positivo, realizar la operacion y volverlo negativo.
            /*
        Numeros positivos 
        while(cont!=1):
            #al iniciar el ciclo por primera vez se debe de multiplicar el numero original (5x4 por ejemplo).
            #se utiliza este bucle para validar esa situacion. Solo se usa una vez y el resto del ciclo se utiliza un acumulador
            if(factorial==cont):
                cont=cont-1
                acumulador=factorial*cont
                print(acumulador)
            else:
                cont=cont-1
                acumulador=acumulador*cont
                print(acumulador)
        Numeros negativos
             */

        }
    
        static void ElevarCuadrado()
        {
            //ENFOQUE: CONVERSION DE TIPOS DE DATOS
            Console.WriteLine("--Elevar al Cuadrado--");
            Console.WriteLine("Ingrese el valor a elevar: ");
            val1 = Console.ReadLine();
            val2 = "2";//Asume el rol de exponente.
            double baseVal = double.Parse(val1);//Funciona como base.
            double expoVal = double.Parse(val2);//Funciona como exponente
            double potencia = Math.Pow(baseVal, expoVal);
            string prefase = potencia.ToString();
            resultado = float.Parse(prefase);//NOTA: DUDA SOBRE USO DE TIPO DE DATOS (FLOAT O DOUBLE).
            Console.WriteLine($"{val1} elevado al cuadrado es: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();

            /*Recursos:
               https://learn.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-7.0
            */
        }

        static void ElevarXY()
        {
            Console.WriteLine("--Elevar al X a Y--");
            Console.WriteLine("Ingrese el valor de X (base): ");
            val1 = Console.ReadLine();//Base
            Console.WriteLine("Ingrese el valor de Y (exponente): ");
            val2 = Console.ReadLine();//Exponente

            double baseVal = double.Parse(val1);
            double expoVal = double.Parse(val2);
            double potencia = Math.Pow(baseVal,expoVal);
            string prefase = potencia.ToString();
            resultado = float.Parse(prefase);
            Console.WriteLine($"{val1} elevado a la {expoVal} es: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();
            /*Recursos:
            https://learn.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-7.0
            */
        }

        static void Elevar10aX()
        {
            Console.WriteLine("--Elevar 10 a X--");
            val1 = "10";
            Console.WriteLine("Ingrese el valor del X (exponente): ");
            val2 = Console.ReadLine();//Exponente

            double baseVal = double.Parse(val1);
            double expoVal = double.Parse(val2);
            double potencia = Math.Pow(baseVal, expoVal);
            string prefase = potencia.ToString();
            resultado = float.Parse(prefase);
            Console.WriteLine($"{val1} elevado a la {expoVal} es: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();
            /*Recursos:
             https://learn.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-7.0
             */
        }

        static void Logaritmo()
        {
            //ENFOQUE: Clarificar si es necesario utilizar el logaritmo natural.
            Console.WriteLine("--Logaritmo--");
            Console.WriteLine("Ingrese el valor a calcular: ");
            val1 = Console.ReadLine();
            double baseVal = double.Parse(val1);
            double prefase = Math.Log(baseVal);
            string val2 = prefase.ToString();
            Console.WriteLine("NOTA: Resultado en formato log e (logaritmo natural con e)");
            Console.WriteLine($"Logaritmo de {val1} es: {val2}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();

            /*Recursos:
            https://learn.microsoft.com/en-us/dotnet/api/system.math.log?view=net-7.0
             */
        }

        static void RaizCuadrada()
        {
            Console.WriteLine("--Raiz Cuadrada elevada al cuadrado--");
            Console.WriteLine("Ingrese el valor de la raiz cuadrada: ");
            val1 = Console.ReadLine();
            double raiz = double.Parse(val1);
            raiz = Math.Sqrt(raiz);
            string val2 = raiz.ToString();
            resultado = float.Parse(val2);
            Console.WriteLine($"El resultado de √{val1} es: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();

            /*Recursos:
             * https://learn.microsoft.com/es-es/dotnet/api/system.math.sqrt?view=net-7.0
             * 
             */
        }
    }
}
