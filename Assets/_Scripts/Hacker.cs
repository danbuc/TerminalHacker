using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string welcome = "Welcome, Hacker-b0Y!";
    // Use this for initialization
    void Start()
    {
        ShowMainMenu(welcome);
    }

    void ShowMainMenu(string welcomeMessage)
    {
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

        if (input == "1")
        {
            Terminal.WriteLine("You choose mission 1.");
        }
        else if (input == "2")
        {
            Terminal.WriteLine("You choose mission 2.");
        }
        else if (input == "3")
        {
            Terminal.WriteLine("You choose mission 3.");
        }
        else if (input == "menu")
        {
            ShowMainMenu(welcome + " Again!");
        }
        else
        {
            Terminal.WriteLine("Choose a valid mission.");
        }
    }
}
