using System;

namespace RegistroUsuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usuarios = new string[4] { "Andy", "Miguel", "Eduardo", "" };
            int indice = 3;

            while (indice<=4)
            {
                Console.WriteLine("Bienvenido, usted cuenta con un usuario?: true/false ");
                Boolean resp = Convert.ToBoolean(Console.ReadLine());
                if (resp == true)
                {
                    Console.Write("Cual es su usuario: ");
                    string usuario = Console.ReadLine();
                    int index = Array.IndexOf(usuarios, usuario);
                    if (index == -1)
                    {
                        Console.WriteLine("Usuario no existe");
                    }
                    else if (indice <= 4)
                    {
                        Console.WriteLine("Es un placer contar con usted "+usuario);
                    }
                    else if (indice < 4)
                    {
                        Console.WriteLine("No se puede registrar mas usuarios");
                        indice++;
                    }
                }
                else if (resp==false && indice<4)
                {
                    Console.Write("Usuario: ");
                    usuarios[indice] = Console.ReadLine();
                    Console.WriteLine("Usuario registrado");
                    indice++;
                }
                else
                {
                    Console.WriteLine("No se puede registrar mas usuarios");
                    indice++;
                }
                Console.WriteLine("\n\n");
            }
            int auxindex = 0;
            Console.WriteLine("LISTA DE USUARIOS: ");
            foreach (string usuario in usuarios)
            {
                Console.WriteLine("Usuario[" + auxindex + "]: " + usuarios[auxindex]);
                auxindex++;
            }
            Environment.Exit(0);
        }
    }
}
