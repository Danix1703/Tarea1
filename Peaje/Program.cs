using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje
{
    internal class Program
    {
        static int[] numeroPlaca = new int[15];
        static int[] numeroFactura = new int[15];
        static string[] fechayhora = new string[15];
        static int[] tipoVehiculo = new int[15];
        static int[] numeroCaseta = new int[15];
        static int[] monto = new int[15];
        static int[] pagacon = new int[15];
        static int[] vuelto = new int[15];
        static int contador = 0;
        static int consulta = 0;
        static byte opcion1 = 0;
        static byte opcion2 = 0;
        static void Main(string[] args)
        {
            menu();
        }//main

        public static void menu()
        {
            opcion1 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("**** Menu ****");
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Ingresar Paso Vehicular");
                Console.WriteLine("3- Consulta Vehiculos por Numero de Placa");
                Console.WriteLine("4- Modificar Datos Vehiculo por Numero de Placa");
                Console.WriteLine("5- Reporte Todos los Datos de los Vectores");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion1 = byte.Parse(Console.ReadLine());

                switch (opcion1)
                {
                    case 1:
                        Inicializar();
                        break;
                    case 2:
                        Ingresar();
                        break;
                    case 3:
                        Consultar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    case 5:
                        Mostrar();
                        break;
                    default:
                        break;
                }//switch
            } while (opcion1 != 6);
        }//menu

        public static void Inicializar()
        {
            for (int i = 0; i < numeroPlaca.Length; i++)
            {
                numeroPlaca[i] = 0;
                numeroFactura[i] = 0;
                fechayhora[i] = "";
                tipoVehiculo[i] = 0;
                numeroCaseta[i] = 0;
                monto[i] = 0;
                pagacon[i] = 0;
                vuelto[i] = 0;

            }
        }//inicializar

        public static void Ingresar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de factura:");
            numeroFactura[contador] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de placa:");
            numeroPlaca[contador] = int.Parse(Console.ReadLine());
            fechayhora[contador] = DateTime.Now.ToString();
            Console.WriteLine("Ingrese el tipo de Vehiculo: 1-Moto 2-Vehiculo Liviano 3-Camion o Pesado 4-Autobus");
            tipoVehiculo[contador] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de caseta: 1, 2 ,3");
            numeroCaseta[contador] = int.Parse(Console.ReadLine());
            switch (tipoVehiculo[contador])
             {
                case 1:
                    monto[contador] = 500;
                    break;
                case 2:
                    monto[contador] = 700;
                    break;
                case 3:
                    monto[contador] = 2700;
                    break;
                case 4:
                    monto[contador] = 3700;
                    break;
                default:
                    break;
             }//switch
                        Console.WriteLine("Ingrese la cantidad con la que se paga:");
                        pagacon[contador] = int.Parse(Console.ReadLine());
                        vuelto[contador] = pagacon[contador] - monto[contador];
            contador++;
        }//Ingresar

        public static void Consultar()
        {
            Console.WriteLine("Ingrese el numero de placa a buscar:");
            consulta = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeroPlaca.Length; i++)
            {
                if (numeroPlaca[i] == consulta)
                {
                    Console.Clear();
                    Console.WriteLine("Numero Factura: " + numeroFactura[i]);
                    Console.WriteLine("Numero Placa : "+ numeroPlaca[i]);
                    Console.WriteLine("Fecha y hora: "+ fechayhora[i]);
                    Console.WriteLine("Tipo de vehiculo: "+ tipoVehiculo[i]);
                    Console.WriteLine("[1-Moto 2-Vehiculo Liviano 3-Camion o pesado 4-Autobus]");
                    Console.WriteLine("Numero caseta: " + numeroCaseta[i]);
                    Console.WriteLine("[1-Caseta1 2-Caseta2 3-Caseta3]");
                    Console.WriteLine("Monto a pagar: " + monto[i]);
                    Console.WriteLine("Paga con: " + pagacon[i]);
                    Console.WriteLine("Vuelto: " + vuelto[i]);
                    Console.WriteLine("");
                    Console.WriteLine("Pulse Enter para continuar...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El numero de plata no se encuentra registrado");
                }
            }//for
        }//consultar

        public static void Modificar()
        {
            Console.WriteLine("Ingrese el numero de placa a buscar:");
            consulta = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeroPlaca.Length; i++)
            {
                if (numeroPlaca[i] == consulta)
                {
                    Console.Clear();
                    Console.WriteLine("Numero Factura: " + numeroFactura[i]);
                    Console.WriteLine("Numero Placa : " + numeroPlaca[i]);
                    Console.WriteLine("Fecha y hora: " + fechayhora[i]);
                    Console.WriteLine("Tipo de vehiculo: " + tipoVehiculo[i]);
                    Console.WriteLine("[1-Moto 2-Vehiculo Liviano 3-Camion o pesado 4-Autobus]");
                    Console.WriteLine("Numero caseta: " + numeroCaseta[i]);
                    Console.WriteLine("[1-Caseta1 2-Caseta2 3-Caseta3]");
                    Console.WriteLine("Monto a pagar: " + monto[i]);
                    Console.WriteLine("Paga con: " + pagacon[i]);
                    Console.WriteLine("Vuelto: " + vuelto[i]);

                    opcion2 = 0;
                    do
                    {
                        Console.WriteLine("Seleccione el valor que desea editar: 1-Numero Factura 2-Numero Placa 3-Tipo de vehiculo 4-Numero caseta 5-Paga con 6-Salir");
                        opcion2 = byte.Parse(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el nuevo numero de factura: ");
                                numeroFactura[i] = int.Parse(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el nuevo numero de placa: ");
                                numeroPlaca[i] = int.Parse(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el nuevo tipo de vehiculo: ");
                                tipoVehiculo[i] = int.Parse(Console.ReadLine());
                                switch (tipoVehiculo[i])
                                {
                                    case 1:
                                        monto[i] = 500;
                                        break;
                                    case 2:
                                        monto[i] = 700;
                                        break;
                                    case 3:
                                        monto[i] = 2700;
                                        break;
                                    case 4:
                                        monto[i] = 3700;
                                        break;
                                    default:
                                        break;
                                }//switch
                                if (pagacon[i]-monto[i]<0)
                                {
                                    Console.WriteLine("La cantidad con la que se paga es menor al nuevo cobro por cambio de vehiculo, por favor ingrese la nueva cantidad con la que paga");
                                    pagacon[i] = int.Parse(Console.ReadLine());
                                }
                                vuelto[i] = pagacon[i] - monto[i];
                                break;
                            case 4:
                                Console.WriteLine("Ingrese el nuevo numero de caseta: ");
                                numeroCaseta[i] = int.Parse(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Ingrese la nueva cantidad con la que paga: ");
                                pagacon[i] = int.Parse(Console.ReadLine());
                                vuelto[i] = pagacon[i] - monto[i];
                                break;
                        }
                    } while (opcion2!=6);
                }//if
                else
                {
                    Console.WriteLine("El numero de placa no se encuentra registrado");
                }//else
            }//for
        }//Modificar

        public static void Mostrar()
        {
            Console.Clear();
            for (int i = 0; i < numeroPlaca.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Numero Factura: " + numeroFactura[i]);
                Console.WriteLine("Numero Placa : " + numeroPlaca[i]);
                Console.WriteLine("Fecha y hora: " + fechayhora[i]);
                Console.WriteLine("Tipo de vehiculo: " + tipoVehiculo[i]);
                Console.WriteLine("[1-Moto 2-Vehiculo Liviano 3-Camion o pesado 4-Autobus]");
                Console.WriteLine("Numero caseta: " + numeroCaseta[i]);
                Console.WriteLine("[1-Caseta1 2-Caseta2 3-Caseta3]");
                Console.WriteLine("Monto a pagar: " + monto[i]);
                Console.WriteLine("Paga con: " + pagacon[i]);
                Console.WriteLine("Vuelto: " + vuelto[i]);
                Console.WriteLine("============================================================");
            }
            Console.WriteLine("Pulse Enter para continuar...");
            Console.ReadLine();
        }






    }//class
}//namespace
