using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to the Matrix.");
        Terminal.WriteLine("We need to increase our resources.");
        Terminal.WriteLine("What is our next mission?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1: Food supplies");
        Terminal.WriteLine("Press 2: Medical supplies");
        Terminal.WriteLine("Press 3: Transport supplies");
        Terminal.WriteLine("");
        Terminal.WriteLine("Your choice: ");
    }
}
