using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;

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


            //ASCII art
            string filePath = "ascii.txt";

            if (File.Exists(filePath)) 
            {
                string heading = File.ReadAllText(filePath);
                Console.WriteLine(heading);
            }

            Console.WriteLine("Welcome");

            //image display as heading in ASCI
            //ask user for name and personalise
            //responsive and handles unexpected or invalid input
            //enhance UI with visual elements
            //github version control
        }
    }
}
