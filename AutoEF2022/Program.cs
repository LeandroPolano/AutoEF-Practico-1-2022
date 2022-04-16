using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoEF2022.Modelos;

namespace AutoEF2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Modificar Auto \n" +
                              "2-Agregar Auto \n" +
                              "3-Eliminar Auto \n" +
                              "4-Mostrar Lista \n" +
                              "5-Salir \n");
            Console.Write("Seleccione una opcion: \n");

            var opcion = int.Parse(Console.ReadLine());

            if (opcion==1)
            {
                ModificarAuto();
            }
            else if (opcion==2)
            {
                AgregarAuto();
            }
            else if (opcion==3)
            {
                EliminarAuto();
            }
            else if (opcion==4)
            {
                ListarRegistros();
            }
            else if (opcion==5)
            {
                
                
            }
            else
            {
                Console.WriteLine("Opcion mal ingresada");
                
            }

            
            
            //ModificarAuto();
            // EliminarAuto();
            // AgregarAuto();

            //ListarRegistros();

            //Console.ReadLine();
        }

        private static void ModificarAuto()
        {
            using (var context = new AutosDbContext())
            {
                Console.Write("Ingrese id del auto a Modificar: ");
                var autoid = int.Parse(Console.ReadLine());


                var AutoEnDB = context.Autos.SingleOrDefault(a => a.AutoId == autoid);

                if (AutoEnDB != null)
                {
                    Console.WriteLine("Modificar auto");

                    Console.Write("Marca: ");
                    var marca = Console.ReadLine();
                    AutoEnDB.Marca = marca;

                    Console.Write("Modelo: ");
                    var modelo = Console.ReadLine();
                    AutoEnDB.Modelo = modelo;

                    Console.Write("Motor: ");
                    var motorcil = Console.ReadLine();
                    AutoEnDB.MotorCil = motorcil;

                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Id ingresado no existe");
                }
            }
            Console.ReadLine();

        }

        private static void EliminarAuto()
        {
            using (var context = new AutosDbContext())
            {
                //context.Database.Log = Console.WriteLine;
                Console.Write("Ingrese id del auto a borrar: ");
                var autoid = int.Parse(Console.ReadLine());


                var AutoEnDB = context.Autos.SingleOrDefault(a => a.AutoId == autoid);

                if (AutoEnDB != null)
                {
                    context.Autos.Remove(AutoEnDB);
                    context.SaveChanges();
                    Console.WriteLine("Registro borrado");
                }
                else
                {
                    Console.WriteLine("Id ingresado no existe");
                }

                context.SaveChanges();
            }
            Console.ReadLine();

        }

        private static void AgregarAuto()
        {
            using (var context = new AutosDbContext())
            {
                var auto = new Auto();
                {
                    Console.WriteLine("ingrese nuevo auto: ");

                    Console.Write("Marca: ");
                    var marca = Console.ReadLine();
                    auto.Marca = marca;

                    Console.Write("Modelo: ");
                    var modelo = Console.ReadLine();
                    auto.Modelo = modelo;

                    Console.Write("Motor: ");
                    var motorcil = Console.ReadLine();
                    auto.MotorCil = motorcil;
                }
                context.Autos.Add(auto);
                context.SaveChanges();
                Console.WriteLine("Registro Agregado");
            }
            //Console.ReadLine();

        }

        private static void ListarRegistros()
        {
            using (var context = new AutosDbContext())
            {
                var lista = context.Autos.ToList();
                foreach (var autos in lista)
                {
                    Console.WriteLine($"Marca: {autos.Marca}, Modelo: {autos.Modelo}, Motor:{autos.MotorCil}");
                }

                Console.WriteLine($"Cantidad de registros: {context.Autos.Count()}");
            }
            Console.ReadLine();
        }

    }
}
