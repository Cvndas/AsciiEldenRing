using System;
using System.Diagnostics;
using System.IO;

class Program
{
    private static bool DEBUG = true;
    static StreamWriter logFile;
    public static void Main()
    {
        Console.WriteLine("Initializing the game\n");

        if (DEBUG) {
            InitializeLogFile();
        }


        if (DEBUG) {
            logFile.Close();
        }
    }

    private static void InitializeLogFile()
    {
        try {
            string currentDirectory = Directory.GetCurrentDirectory();

            logFile = new StreamWriter(Path.Combine(currentDirectory, "logging/logFile.txt"), false);
            logFile.WriteLine("Game Begin");
            
        }
        catch (Exception e){
            Console.WriteLine("ERROR IN InitializeLogFile: " + e.Message + "\nDisabled DEBUG");
            DEBUG = false;
            logFile.Close();
        }

    }
}