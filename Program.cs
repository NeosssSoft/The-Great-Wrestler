using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TheGreatWrestler
{
    class Program
    {
        //Variables
        static string sino;
        //Clases
        static player player = new player(); //Creamos el objeto del jugador
        //Funciones
        public static void saveGame() //Guardar Partida
        {
            FileStream fs = new FileStream("savegame.txt", FileMode.Create);
            fs.Write(ASCIIEncoding.ASCII.GetBytes(player.namePlayer), 0, player.namePlayer.Length);
            fs.Close();

        }
        public static void loadGame() //Cargar Partida
        {
            player.namePlayer = System.IO.File.ReadAllText("savegame.txt");
        }
        public static void textColor(int color, string texto) //Funcion encargada de colorear el texto
        {
            if (color == 0) //Blanco
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(texto);
                Console.ResetColor();
            }
            if (color == 1) // Verde
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(texto);
                Console.ResetColor();
            }
            if (color == 2) //Rojo
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(texto);
                Console.ResetColor();
            }
            if (color == 3) // Azul
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(texto);
                Console.ResetColor();
            }
            if (color == 4) // Amarillo
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(texto);
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            textColor(1, "The Great Wrestler");
            Console.WriteLine("Una historia donde tu te convertiras en una super estrella de la lucha libre profesional");
            Console.WriteLine("Por favor presione una tecla");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("¿Desea cargar partida?");
            sino = Console.ReadLine();
            if (sino == "y")
            {
                loadGame();
                Console.WriteLine("Cargado nombre: " + player.namePlayer);
                
            }
            else
            {
                Console.WriteLine("¿Cual es el nombre de tu luchador?");
                player.namePlayer = Console.ReadLine(); //Leemos el nombre del jugador
                Console.WriteLine("Bienvenido " + player.namePlayer); //Mostramos el nombre del jugador
                saveGame();
                Console.ReadKey();

            }
            
        }
    }
}
