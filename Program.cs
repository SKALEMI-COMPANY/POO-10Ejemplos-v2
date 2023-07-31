using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Skalemi Company
// Si te surge alguna duda, contáctame.
// michaelvinces.skalemi@gmail.com

namespace POO_10Ejemplos_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuActivo = true;
            while (menuActivo)
            {
                menuActivo = MenuBasico();
            }
            Console.ReadKey();
        }
        private static bool MenuBasico()
        {
            Console.WriteLine("--------| PRÁCTICA 2 |--------");
            Console.WriteLine("Programas elaborados por SKALEMI COMPANY\n");
            Console.WriteLine("01. El Mayor de dos números");
            Console.WriteLine("02. Número Par");
            Console.WriteLine("03. El mayor de tres números");
            Console.WriteLine("04. Leer números decimales indefinidamente ");
            Console.WriteLine("05. Suma de 5 números");
            Console.WriteLine("06. Suma de los números deseados");
            Console.WriteLine("07. Tipo de triángulo");
            Console.WriteLine("08. Múltiplos del 7 desde 1 al 100");
            Console.WriteLine("09. Promedio de los números ingresados");
            Console.WriteLine("10. Factorial");
            Console.WriteLine("11. Salir");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Elija la opción que quiera procesar");
            Console.WriteLine("________________________________________________");
            string opcion = Console.ReadLine();
            Console.Clear();
            if (opcion == "1")
            {
                int Numero1, Numero2;
                do
                {
                    Console.WriteLine("Programa 1");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("******      EL MAYOR DE DOS NÚMEROS      ********");
                    Console.WriteLine("*************************************************");                
                    Console.Write("Ingrese el primer número: ");
                    Numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    Numero2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("________________________________________________");
                    if (Numero1 == Numero2)
                    {
                        Console.WriteLine("ERROR... Los números ingresados son iguales, intente nuevamente...");
                        Console.ReadLine();
                        Console.Clear();                       
                    }
                    if (Numero1 > Numero2)
                    {
                        Console.WriteLine("El número "+Numero1+" es mayor que "+Numero2);
                        Console.WriteLine("________________________________________________");
                    }
                    if (Numero1 < Numero2)
                    {
                        Console.WriteLine("El número " + Numero2 + " es mayor que " + Numero1);
                        Console.WriteLine("________________________________________________");
                    }
                } while (Numero1 == Numero2);
                Console.WriteLine("\nPresione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();

                return true;
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Programa 2");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********           Número Par            ********");
                Console.WriteLine("*************************************************");
                int Residuo=0;
                Console.Write("Ingrese un número: ");
                int Numero = int.Parse(Console.ReadLine());
                Residuo = Numero % 2;
                Console.WriteLine("________________________________________________");
                if (Residuo == 0)
                {
                    Console.WriteLine("El número "+Numero+" es par.");
                }
                else
                {
                    Console.WriteLine("El número "+Numero+" no es par.");
                }
                
                Console.WriteLine("________________________________________________");
                Console.WriteLine("\nPresione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "3")
            {                
                int Numero1, Numero2, Numero3;
                do
                {
                    Console.WriteLine("Programa 3");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("******     EL MAYOR DE TRES NÚMEROS        ******");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("Los datos que ingrese deberán ser diferentes!!\n");
                    Console.Write("Ingrese el primer número: ");
                    Numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    Numero2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el tercer número: ");
                    Numero3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("________________________________________________");
                    
                    if (Numero1 == Numero2 || Numero2==Numero3 ||Numero1==Numero3)
                    {
                        Console.WriteLine("ERROR... Existen números iguales, intente nuevamente...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (Numero1 > Numero2 && Numero1>Numero3)
                    {
                        Console.WriteLine("El número " + Numero1 + " es mayor que " + Numero2+" y que el "+Numero3+".");
                        Console.WriteLine("________________________________________________");
                    }
                    if (Numero1 < Numero2 && Numero3<Numero2)
                    {
                        Console.WriteLine("El número " + Numero2 + " es mayor que " + Numero1 + " y que el " + Numero3 + ".");
                        Console.WriteLine("________________________________________________");
                    }
                    if (Numero3 > Numero1 && Numero3 > Numero2)
                    {
                        Console.WriteLine("El número " + Numero3 + " es mayor que " + Numero1 + " y que el " + Numero2 + ".");
                        Console.WriteLine("________________________________________________");
                    }
                } while (Numero1 == Numero2 || Numero2 == Numero3 || Numero1 == Numero3);
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Programa 4");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*******       NÚMEROS DECIMALES          ********");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Cuando digite el número 0 se finaliza el programa...");
                int contador=0;
                double Numero;
                do
                {
                    contador++;
                    Console.Write(contador + "-> ");
                    Numero = double.Parse(Console.ReadLine());
                    
                } while (Numero != 0);
                Console.WriteLine("\nPrograma Finalizado...");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "5")
            {
                Console.WriteLine("Programa 5");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*******         SUMA DE 5 NÚMEROS        ********");
                Console.WriteLine("*************************************************");
                int Suma=0, contador = 0;
                while(contador<5)
                {
                    contador++;
                    Console.Write("Ingrese el número "+contador+": ");
                    int Numero = int.Parse(Console.ReadLine());
                    Suma = Suma + Numero;
                }
                Console.WriteLine("\n________________________________________________");
                Console.WriteLine("La suma de los "+contador+" números ingresados es "+Suma+".");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "6")
            {
                Console.WriteLine("Programa 6");
                Console.WriteLine("*************************************************");
                Console.WriteLine("****      SUMA DE LOS NÚMEROS DESEADOS      *****");
                Console.WriteLine("*************************************************");
                int Numero, Suma = 0, contador = 0;
                Console.WriteLine("Cuando digite 0 se terminará el proceso calculando \nla suma de los números previamente ingresados...");
                do
                {
                    contador++;
                    Console.Write("Ingrese el número " + contador + ": ");
                    Numero = int.Parse(Console.ReadLine());
                    Suma = Suma + Numero;
                } while (Numero != 0);
                contador = contador - 1;
                Console.WriteLine("\n________________________________________________");
                Console.WriteLine("La suma de los " + contador + " números ingresados es " + Suma + ".");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "7")
            {
                Console.WriteLine("Programa 7");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*******           TRIÁNGULOS            *********");
                Console.WriteLine("*************************************************");
                double Lado1, Lado2, Lado3;
                string Respuesta;
                do
                {
                    Console.Write("Ingrese la medida del primer lado: ");
                    Lado1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la medida del segundo lado: ");
                    Lado2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la medida del tercer lado: ");
                    Lado3 = int.Parse(Console.ReadLine());
                    if (Lado1 == Lado2 && Lado1 == Lado3)
                    {
                        Console.WriteLine("\nEl triángulo ingresado es un Equilatero.\n");
                    }                    
                    else if (Lado1 != Lado2 && Lado1 != Lado3 && Lado2 != Lado3)
                    {
                        Console.WriteLine("\nEl triángulo ingresado es un Escaleno.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nEl triángulo ingresado es un Isóceles.\n");
                    }
                    do
                    {
                        Console.WriteLine("Desea calcular otro triángulo? Responda S->Si o N->No ");
                        Respuesta = Console.ReadLine();
                        Console.WriteLine("________________________________________________");
                        if (!Respuesta.Equals("S") && !Respuesta.Equals("N"))
                        {
                            Console.WriteLine("ERROR.... Solo puede responder |S| (Si) o |N|(No).");
                            Console.WriteLine("________________________________________________");
                        }

                    } while (!Respuesta.Equals("S") && !Respuesta.Equals("N"));
                } while (Respuesta.Equals("S"));
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "8")
            {
                Console.WriteLine("Programa 8");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*****    MÚLTIPLOS DEL 7 desde 1 al 100     *****");
                Console.WriteLine("*************************************************");
                int multiplo=0;
                do
                {
                    multiplo = multiplo + 7;
                    if (multiplo < 100)
                    {
                        Console.WriteLine(multiplo);
                    }
                } while (multiplo < 100);
                Console.WriteLine("\n________________________________________________");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.WriteLine("________________________________________________");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "9")
            {
                Console.WriteLine("Programa 9");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********            PROMEDIO           **********");
                Console.WriteLine("*************************************************");
                int Numero, contador = 0;
                double Suma = 0, Promedio=0;
                Console.WriteLine("Cuando digite 0 se terminará el proceso calculando \nel promedio de los números previamente ingresados...");
                do
                {
                    contador++;
                    Console.Write("Ingrese el número " + contador + ": ");
                    Numero = int.Parse(Console.ReadLine());
                    Suma = Suma + Numero;
                } while (Numero != 0);
                contador = contador - 1;
                Promedio = Suma / contador;
                Console.WriteLine("\n________________________________________________");
                Console.WriteLine("El promedio de los " + contador + " números ingresados es " + Promedio + ".");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "10")
            {
                Console.WriteLine("Programa 10");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********           FACTORIAL           **********");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Indique un numero entero para realizar\nsu respectivo factorial: ");
                int Numero = int.Parse(Console.ReadLine());
                int contador = 0, secuencia = 0, Factorial = 1;
                while (contador < Numero)
                {
                    contador++;
                    if (contador == 1)
                    {
                        Console.Write(Numero + "!= ");
                        secuencia = Numero;
                    }
                    if (secuencia != 1)
                    {
                        Console.Write(secuencia + " * ");
                        if (secuencia > 1)
                        {
                            Factorial = Factorial * secuencia;
                            secuencia = secuencia - 1;
                        }

                    }
                    else
                    {
                        if (secuencia > 1)
                        {
                            Factorial = Factorial * secuencia;
                        }


                        Console.WriteLine(secuencia + " = " + Factorial);
                    }
                }
                Console.WriteLine("El resultado del factorial del número " + Numero + " es: " + Factorial);
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.WriteLine("________________________________________________");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "11")
            {
                Console.WriteLine("Gracias por usar mi Programa...\nMichael Vinces Andrade te agradece... :)");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
           
            return false;

        }

    }
}
