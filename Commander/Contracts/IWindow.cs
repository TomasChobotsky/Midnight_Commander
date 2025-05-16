using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commander.Components;
using Commander.Core;
using Commander.Data;

namespace Commander.Contracts
{
    public interface IWindow
    {
        int Width { get; set; }
        int Height { get; set; }
        Pixel[,] Buffer { get; set; }
        Pixel[,] TempBuffer { get; set; }
        public ComponentControl ComponentControl { get; set; }

        void Start();
        int GetWidthByPortion(double portion);
        int GetHeightByPortion(double portion);
        void Render();
        void CreateWindow();

        public event EventHandler<WindowResizedEventArgs> WindowResizedEvent;
    }
}