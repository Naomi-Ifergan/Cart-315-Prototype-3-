using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject instructions;
    public GameObject mainScreen;


    void Start()

    {

        instructions.SetActive(false);

        mainScreen.SetActive(true);

    }

    public void ShowInstructions()

    {

        instructions.SetActive(true);

        mainScreen.SetActive(false);

    }
    public void HideInstructions()

    {

        instructions.SetActive(false);

        mainScreen.SetActive(true);

    }

    public void PlayGame()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
}










