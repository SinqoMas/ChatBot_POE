using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace POE_st10203232
{
    class Program
    {
        static void Main(string[] args)
        {

            //voice greeting
            string audio = "welcome.wav";

            using (var audioFile = new AudioFileReader(audio))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                // Wait until the sound finishes playing
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }

            Console.WriteLine("Playing audio...");
            //image display as heading in ASCII
            //ask user for name and personalise
            //responsive and handles unexpected or invalid input
            //enhance UI with visual elements
            //github version control
        }
    }
}
