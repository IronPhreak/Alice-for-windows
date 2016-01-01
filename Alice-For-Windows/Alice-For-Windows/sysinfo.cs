using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace Win_Alice
{
    class sysinfo
    {

        public static void battsetup()
        {
            Task T = new Task(()=>
            {
                Console.WriteLine("Starting Battery Monitor");
                batterylvl();
            });
            T.Start();
        }

        public static void batterylvl()
        {
            PowerStatus pw = SystemInformation.PowerStatus;
            while (true)
            {
                if(pw.PowerLineStatus == PowerLineStatus.Offline)
                {

                    if ((pw.BatteryLifePercent * 100) <= 99 )
                    {
                        string alert = "Your battery level is at " + (pw.BatteryLifePercent * 100).ToString() + "/%. \n Remaining time left is " + pw.BatteryLifeRemaining;
                        Speech.say(alert);
                        MessageBox.Show(alert,"Battery Level",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        
                    }

                    while (pw.PowerLineStatus == PowerLineStatus.Offline)
                    {
                        //do nothing
                    }

                }

            }
            
        }


    }
}
