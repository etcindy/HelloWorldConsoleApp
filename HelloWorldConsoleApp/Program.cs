using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    class Program
    {
        private static bool cancel = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Application has started. Ctrl-C to end");

            string helloworld = "This is a Hello World program";
                        //write Hello world to console
                      Console.WriteLine(helloworld);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

           
            var autoResetEvent = new AutoResetEvent(false);
            Console.CancelKeyPress += (sender, eventArgs) =>
            {
                // cancel the  the program 
                eventArgs.Cancel = true;
                autoResetEvent.Set();
            };

            // waiting for ctrl-C
            autoResetEvent.WaitOne();
            cancel = true;
            Console.WriteLine("Now shutting down");

            
        }

        
        
    }
    
}
