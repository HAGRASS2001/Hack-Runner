using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camHack : MonoBehaviour
{
    // Start is called before the first frame update
    enum Screen { MainMenu, Password, MainMenu1, quite }; //defines so that user can switch screen upon entering the game
    Screen currentScreen; //variable for the screen that will be equal to the current screen
    string password;

    // Start is called before the first frame update
    void Start()
    {
        login();
    }
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu1;
        Terminal.ClearScreen();
        Terminal.WriteLine("-------Welcome ---------------");
        Terminal.WriteLine("What would you like to open ?");
        Terminal.WriteLine("Press 1 for map ");
        Terminal.WriteLine("Press 2 for camRecord  ");
        Terminal.WriteLine("Enter your selection:");

    }




    void map()
    {
        currentScreen = Screen.quite;
        Terminal.ClearScreen();
        Terminal.WriteLine("-------Welcome ---------------");
        Terminal.WriteLine("_______________________________");
        Terminal.WriteLine("| reception  |     |          |");
        Terminal.WriteLine("|      |          |           |");
        Terminal.WriteLine("|_____________________________|");
        Terminal.WriteLine("| Marcanos office  |          |");
        Terminal.WriteLine("|   |        |     |          |");
        Terminal.WriteLine("|                             |");
        Terminal.WriteLine("|_____________________________|");
        Terminal.WriteLine("[ Enter map ]");
    }
    void login()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("-----Welcome to Marcanos Company-------");
        Terminal.WriteLine("--------Press 1 to login-------------- ");
    }

    void OnUserInput(string input) //Function that checks which screen the user will redirect into
    {


        if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            checkpassword(input);
        }
        else if (currentScreen == Screen.MainMenu1)
        {
            runmap(input);
        }
        else if (currentScreen == Screen.quite)
        {
            runDownloadMap(input);
        }
    }
    void RunMainMenu(string input)
    {

        if (input == "1")
        {
            AskForPassword();

        }
        else
        {
            Terminal.WriteLine("Please choose a valid option");

        }

    }
    void runmap(string input)
    {
        if (input == "1")
        {
            map();
        }
        else
        {
            Terminal.WriteLine("EMPTY FILE");
        }
    }

    void runDownloadMap(string input)
    {
        if (input == "map")
        {
            Application.Quit();//or go to level 4 
            //Application.LoadLevel(5);

        }
        else
        {
            Terminal.WriteLine("Enter map to download the map");
        }
    }






    void AskForPassword()
    {//Function that calls for the screen //The user will
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Hint:password is guard123");
        Terminal.WriteLine("Enter your Password : ");
        SetPassword();

    }
    void SetPassword()
    {
        password = "guard123";
    }

    void checkpassword(string input)
    {
        if (input == password)
        {
            ShowMainMenu();
        }
        else
        {
            AskForPassword();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
