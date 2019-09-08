using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonFunctions : MonoBehaviour {

    Canvas backToMainScreen;

    public Button Yes;
    public Button No;


    void Start() {
        backToMainScreen = GameObject.Find("BackToMainScCanvas").GetComponent<Canvas>();

        Button yes = Yes.GetComponent<Button>();
        yes.onClick.AddListener(LoadMainScreen);

        Button no = No.GetComponent<Button>();
        no.onClick.AddListener(ReturnToGame);
    }

    void LoadMainScreen() {
        SceneManager.LoadScene("GameBeginScreen");
        Time.timeScale = 1;
    }

    void ReturnToGame() {
        backToMainScreen.enabled = false;
        Time.timeScale = 1;
    }
}
