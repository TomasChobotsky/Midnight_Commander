using System;

namespace Commander.Contracts
{
    public interface IInputHandler
    {
        event EventHandler<ConsoleKey> KeyDownEvent;

        void ListenToInput();
    }
}