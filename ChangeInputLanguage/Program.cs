using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace ChangeInputLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            // cmd -> cd -> "ChangeInputLanguage.exe 10 15"

            Thread.Sleep(int.Parse(args[0]));

            InputSimulator.SimulateKeyDown(VirtualKeyCode.LWIN);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.SPACE);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.LWIN);

            Thread.Sleep(int.Parse(args[1]));
        }
    }
}
