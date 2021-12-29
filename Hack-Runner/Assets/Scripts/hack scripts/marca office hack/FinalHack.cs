using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Terminal.WriteLine("-------Welcome Mr.Marcano---------------");
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
        Terminal.WriteLine("-------Welcome Mr.Marcano---------------");
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
        Terminal.WriteLine("-----Welcome to Marcano's Company-----");
        Terminal.WriteLine("-----------Press 1 to login-----------");
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
            Terminal.WriteLine("Success!!!");
            Invoke("done", 2);
        }
        else
        {
            Terminal.WriteLine("Enter download to download this file");
        }
    }
    void done()
    {
        FindObjectOfType<finalhackonandoff>().display.SetActive(false);
        FindObjectOfType<finalhackonandoff>().keyboad.SetActive(false);
        FindObjectOfType<finalhackonandoff>().Terminal.SetActive(false);
        FindObjectOfType<PlayerGuidance>().guidance5part2.SetActive(false);
        Destroy(FindObjectOfType<playercontroller>().gameObject);
        SceneManager.LoadScene(14);
    }

    void AskForPassword() {//Function that calls for the screen //The user will
        currentScreen=Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your Password : ");
        SetPassword();
       
    }
    void SetPassword()
    {
        password = "moco2000";
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

