using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;



public class mainmenu : MonoBehaviour
{
    public string PlayerName;
    public InputField loginInputName;
    public string[] Scores;
  
    // identifies the loginInputName and loginErrorText as game obejcts to be used 
    // instantiates PlayerName as a string
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Playgame()
    {
        PlayerName = loginInputName.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Menu loaded");
        Debug.Log("player name is " + PlayerName);

       
        
    }
        
}
