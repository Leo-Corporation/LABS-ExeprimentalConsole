﻿using LABS_Experimental_Console.Classes;
using System;
using System.Linq;

namespace LABS_Experimental_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().GoHome();
        }

        public void ExecuteCommand(string command)
        {
            if (!IsCommandExist(command))
            {
                WriteWrongCommandMessage();
            }
            else
            {
                switch (command.ToLower())
                {
                    case "help": // Si la commande est "help"
                        Functions.WriteHelp();
                        GoHome();
                        break;
                    case "ver": // Si la commande est "help"
                        Console.ForegroundColor = ConsoleColor.Blue; // Changer la couleur
                        Console.WriteLine("Version {0}, Copyright {1} - Léo Corporation", Definitions.Version, DateTime.Now.Year); // Ecrire
                        GoHome();
                        break;
                    case "about": // Si la commande est "help"
                        Console.ForegroundColor = ConsoleColor.Blue; // Changer la couleur
                        Console.WriteLine("LABS Experimental Console © {0}", DateTime.Now.Year) ; // Ecrire
                        GoHome();
                        break;
                    case "cls":
                        Console.Clear(); // Effacer
                        GoHome();
                        break;
                    case "clear":
                        Console.Clear(); // Effacer
                        GoHome();
                        break;
                    case "list":
                        Functions.WriteCommands();
                        GoHome();
                        break;
                    case "update":

                        GoHome();
                        break;
                }
            }
        }

        public void GoHome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Changer la couleur
            Console.WriteLine(""); // Ecrire
            Console.WriteLine("Pour commencer, tapez une commande. Tapez 'help' pour afficher l'aide."); // Ecrire
            Console.ResetColor(); // Mettre la couleur par défaut
            ExecuteCommand(Console.ReadLine());
        }

        public void WriteWrongCommandMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Mettre en rouge
            Console.WriteLine("La commande que vous avez executée n'existe pas."); // Afficher le message
            Console.ResetColor(); // Mettre la couleur par défaut
            GoHome();
        }

        public bool IsCommandExist(string command)
        {
            bool res = true; // Résultat
            if (Definitions.Commands.Contains(command))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
