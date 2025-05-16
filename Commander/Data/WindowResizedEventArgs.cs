using System;
using System.Runtime.CompilerServices;
using Commander.Contracts;

namespace Commander.Data
{
    public class WindowResizedEventArgs
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}