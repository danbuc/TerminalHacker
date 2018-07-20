using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string welcome = "Welcome, Hacker-b0Y!";
    int level;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Use this for initialization
    void Start()
    {
        ShowMainMenu(welcome);
    }

    void ShowMainMenu(string welcomeMessage)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(welcomeMessage);
        Terminal.WriteLine("We need to increase our resources.");
        Terminal.WriteLine("What is our next mission?");
        Terminal.WriteLine("---");
        Terminal.WriteLine("Press 1: Food supplies");
        Terminal.WriteLine("Press 2: Medical supplies");
        Terminal.WriteLine("Press 3: Transport supplies");
        Terminal.WriteLine("---");
        Terminal.WriteLine("Your choice: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu(welcome + " Again!");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            Terminal.WriteLine("You choose mission " + level);
            StartGame();

        }
        else if (input == "2")
        {
            level = 2;
            Terminal.WriteLine("You choose mission " + level);
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            Terminal.WriteLine("You choose mission " + level);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Choose a valid mission.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("Welcome to mission " + level);
        Terminal.WriteLine("Enter your password:");
    }
}
