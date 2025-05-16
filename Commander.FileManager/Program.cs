using Commander.Contracts;
using Commander.Core;
using System;
using System.Collections.Generic;

namespace Commander.FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            MainView mainView = new MainView();
            mainView.ConstructView();
        }
    }
}