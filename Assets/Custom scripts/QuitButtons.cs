using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitButtons : MonoBehaviour {

    Canvas quitGame;

    public Button Yes;
    public Button No;

    public static bool allowQuit = false;


    private void Start()
    {
        quitGame = GameObject.Find("QuitGameQ").GetComponent<Canvas>();

        Button yes = Yes.GetComponent<Button>();
        yes.onClick.AddListener(Quit);

        Button no = No.GetComponent<Button>();
        no.onClick.AddListener(BackToGame);
    }


    void Quit()
    {
        allowQuit = true;
        Application.Quit();
    }

    void BackToGame()
    {
        quitGame.enabled = false;
        Time.timeScale = 1;
    }
}
