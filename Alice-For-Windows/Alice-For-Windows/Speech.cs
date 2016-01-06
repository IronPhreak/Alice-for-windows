using System;

using System.Speech.Synthesis;

namespace Alice_For_Windows
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