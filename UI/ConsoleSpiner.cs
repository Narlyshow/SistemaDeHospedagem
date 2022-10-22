using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem.UI
{
    class ConsoleSpiner
    {
        public int counter { get; set; }
        public ConsoleSpiner()
        {
            counter = 0;
        }
        public void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

    }
}
