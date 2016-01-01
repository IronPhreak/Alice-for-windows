using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;

namespace Win_Alice
{
    class Speech
    {
        public static void say(string Say)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(Say);
            Console.Clear();
            Console.WriteLine(Say);
        }
    }
}
