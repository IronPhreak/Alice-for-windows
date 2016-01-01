using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            console_setup.consoleSetup();
            Task T = new Task(sysinfo.battsetup);
            T.Start();
            T.Wait();
            Task.Delay(5000).Wait();
            Console.Write("Starting A.L.I.C.E");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Task.Delay(1000).Wait();
            }
            commandInput();
              
        }

        static void commandInput()
        {
            while (true)
            {
                console_setup.header();
                Console.Write("Command: ");
                string input = Console.ReadLine();
                Console.Clear();
                Task T = new Task(() => { Choices.choice(input); });
                T.Start();
                T.Wait();

                Console.Clear();
            }
        }
        
    }

    class console_setup
    {
        public static void consoleSetup()
        {
            Console.Title = "A.L.I.C.E";

            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Text = "ALICE";
            trayIcon.BalloonTipTitle = "ALICE";
            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.BalloonTipText = "Alice tray icon";
            trayIcon.ShowBalloonTip(500);
            trayIcon.Visible = true;

        }
        public static void header()
        {
            Console.Clear();
            Console.WriteLine(@"    ___    __    ________________");
            Console.WriteLine(@"   /   |  / /   /  _/ ____/ ____/");
            Console.WriteLine(@"  / /| | / /    / // /   / __/   ");
            Console.WriteLine(@" / ___ |/ /____/ // /___/ /___   ");
            Console.WriteLine(@"/_/  |_/_____/___/\____/_____/   ");
        }
    }

    class Choices
    {

        public static void choice(string Query)
        {
            if(Query == "test")
            {
                MessageBox.Show("This is a test");
            }
        }
    }
}
