using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalHack : MonoBehaviour
{
   
    
    int option;
    enum Screen { MainMenu, Password, MainMenu1 , quite }; //defines so that user can switch screen upon entering the game
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
            Terminal.WriteLine("-------Welcome Mr.Marcanos---------------");
            Terminal.WriteLine("What would you like to open ?");
            Terminal.WriteLine("Press 1 for go to Files");
            Terminal.WriteLine("Press 2 for camRecord  ");
            Terminal.WriteLine("Press 3 for a Social Media");
            Terminal.WriteLine("Enter your selection:");
       
        }


   

    void files() 
    {
        currentScreen = Screen.quite;
        Terminal.ClearScreen();
        Terminal.WriteLine("-------Welcome Mr.Marcanos---------------");
        Terminal.WriteLine("*************************");
        Terminal.WriteLine("*                        *");
        Terminal.WriteLine("*          Secret Files  *");
        Terminal.WriteLine("*                        *");
        Terminal.WriteLine("*************************");
        Terminal.WriteLine("[ Enter download ]");
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
            runfiles(input);
        }
        else if (currentScreen == Screen.quite)
        {
            runDownloadFile(input);
        }
    }
    void RunMainMenu(string input)
    {

        if (input=="1")
        {
            AskForPassword();

        }
        else
        {
            Terminal.WriteLine("Please choose a valid option");
           
        }

    }
    void runfiles(string input)
    {
        if (input == "1")
        {
            files();
        }
        else {
            Terminal.WriteLine("EMPTY FILE");
        }
    }

    void runDownloadFile(string input)
    {
        if (input == "download")
        {
            Application.Quit();//or go to level 4 
            //Application.LoadLevel(5);

        }
        else
        {
            Terminal.WriteLine("Enter download to download this file");
        }
    }

    



   
    void AskForPassword() {//Function that calls for the screen //The user will
        currentScreen=Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Hint:password is marca");
        Terminal.WriteLine("Enter your Password : ");
        SetPassword();
       
    }
    void SetPassword()
    {
        password = "marca";
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

