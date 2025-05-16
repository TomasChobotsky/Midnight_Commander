using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Commander.Contracts;

namespace Commander.Core
{
    public class InputHandler : IInputHandler
    {
        public event EventHandler<ConsoleKey> KeyDownEvent;

        public InputHandler()
        {
            ListenToInput();
        }

        public void ListenToInput()
        {
            new Thread(() =>
            {
                while (true)
                {
                    ConsoleKey input = Console.ReadKey(true).Key;
                    KeyDownEvent?.Invoke(this, input);
                }
            }).Start();
           
        }
    }
}