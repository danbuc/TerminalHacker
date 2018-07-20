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
    const string goToMenuHint = "You can type 'menu' at any time to choose a different mission.";

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
            AskForPassword();
        }
        else
        {
            Terminal.WriteLine("Choose a valid mission.");
            Terminal.WriteLine(goToMenuHint);
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("Enter your password:");
        Terminal.WriteLine("Hint: " + password.Anagram());


    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, 4)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, 4)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, 4)];
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
            ShowWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void ShowWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(goToMenuHint);
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Let's eat!");
                Terminal.WriteLine(@"
      _ __,~~~/
,~~`( )_( )-\|
    |/|  `--.
    ! !  !
                ");
                break;
            case 2:
                Terminal.WriteLine("We restored our health!");
                Terminal.WriteLine(@"
      _ __,~~~/
,~~`( )_( )-\|
    |/|  `--.
    ! !  !
                ");
                break;
            case 3:
                Terminal.WriteLine("Time to travel!");
                Terminal.WriteLine(@"
      _ __,~~~/
,~~`( )_( )-\|
    |/|  `--.
    ! !  !
                ");
                break;
            default:
                Debug.LogWarning("What happend?");
                break;
        }
    }

}
