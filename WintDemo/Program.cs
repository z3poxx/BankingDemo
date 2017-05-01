using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WintDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runDemoApp = true;

            Messages.Greet(); 
            Messages.ExplainBasicControls();
                        

            while (runDemoApp)
            {
                ConsoleKeyInfo consoleInput = Console.ReadKey();


                if (consoleInput.KeyChar == '0')
                {
                    Messages.ExplainBasicControls();
                }


                if (consoleInput.KeyChar == '1')
                {
                    Messages.TempMSG();
                    //do stuff
                }

            }

        }
    }
}
