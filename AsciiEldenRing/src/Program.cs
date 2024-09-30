#define DEBUG 

using System;
using System.Diagnostics;
using System.IO;


class Program
{
    private static StreamWriter? logFile;


    //------------------------- MAIN METHOD -----------------------------------//
    public static void Main()
    {
        Console.WriteLine("Initializing the game\n");
#if DEBUG
        try {
            InitializeLogFile();
        }
        catch (Exception e) {
            Console.WriteLine("ERROR IN InitializeLogFile: " + e.Message + "\nClosing program.");
            return;
        }
#endif

        InitializeGame();
        GameState.GameLoop();

#if DEBUG
#pragma warning disable CS8602
        logFile.Close();
#endif
    }


    //---------------------------------------------------------------------------------//

    private static void InitializeLogFile()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        logFile = new StreamWriter(Path.Combine(currentDirectory, "logging/logFile.txt"), false);
        logFile.WriteLine("Game Begin");
    }

    private static void InitializeGame()
    {
        GameState.GameStateInit();
        DisplayManager.DisplayManagerInit();
        // TODO : Load saves from disk
    }

#if DEBUG
    // DEBUG PRINT
    public static void DD(string text)
    {
#pragma warning disable CS8602
        logFile.WriteLine(text);
    }

    // ASSERT
    public static void AA(Boolean value){
        Debug.Assert(value);
    }
#endif
}