using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

    Canvas backToMainScreen;
    Canvas quitQuestion;


    private void Start()
    {
        backToMainScreen = GameObject.Find("BackToMainScCanvas").GetComponent<Canvas>();
        quitQuestion = GameObject.Find("QuitGameQ").GetComponent<Canvas>();

    }

    void Update () {

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Time.timeScale = 0;                 // Pause Game
            backToMainScreen.enabled = true;
        }       
    }

    void OnApplicationQuit() {
        quitQuestion.enabled = true;
        Time.timeScale = 0;
        if(!QuitButtons.allowQuit)
            Application.CancelQuit();

    }
}