using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        loadingscreen,
        delen,
        ezwin,
        foutenzijngemaakt,
        ontsnapt,
        terugkeer,
        dezelfdefout,
        boss1,
        winst,
        verlies,
        safepoint,
        ziekenhuiswinst,
        eindelijkvrij,
        dood,
        decult,
    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        Terminal.WriteLine("In de terminal");
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij HorrorNight");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ start om te beginnen");
    }
    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }
                else if (input == "9999")
                {
                    Terminal.WriteLine("YEET you instantly died!");
                }
                else if (input == "abcd")
                {
                    Terminal.WriteLine("begin gewoon met de game domoor");
                }
                else if (input == "DEAD")
                {
                    Terminal.WriteLine("Typ gewoon start dombo");
                }

                break;
            case States.loadingscreen:
                if (input == "YOLO")
                {
                    GegevensDelen();
                }

                break;
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude, donkere nacht");
        Terminal.WriteLine("Een hele goede nacht om thuis op je laptop te gamen");
        Terminal.WriteLine("Typ YOLO om verder te gaan");
        currentState = States.loadingscreen;
    }

    void GegevensDelen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Een speler vraagt om je Discord gegevens");
        Terminal.WriteLine("Wil je deze met de speler delen?");
        Terminal.WriteLine("Typ ja om te delen");
        Terminal.WriteLine("Typ nee om niet te delen");
        currentState = States.delen;
    }



    // Update is called once per frame

    void Update()
    {
        
    }
}
