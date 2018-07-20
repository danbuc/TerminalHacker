using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string welcome = "Welcome, Hacker-b0Y!";
    int level;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    string password;

    string[] level1Passwords = { "banana", "pineapple", "hamburger", "salad", "sausages" };
    string[] level2Passwords = { "aspirin", "firstaidkit", "hospitalclothes", "medicalgauntlet", "painkiller" };
    string[] level3Passwords = { "fastcar", "largetruck", "superlongtrain", "flyingairplane", "superflyinghelicopter" };

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
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");

        if (isValidLevelNumber)
        {
            level = int.Parse(input);
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
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your password:");

        switch (level)
        {
            case 1:
                password = level1Passwords[0];
                break;
            case 2:
                password = level2Passwords[0];
                break;
            case 3:
                password = level3Passwords[0];
                break;
            default:
                Debug.LogWarning("Invalid Level");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Supplies accessed!");
        }
        else
        {
            Terminal.WriteLine("WRONG PASSWORD!");
            Terminal.WriteLine("Enter your password:");
        }
    }
}
