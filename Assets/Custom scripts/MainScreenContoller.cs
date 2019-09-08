using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScreenContoller : MonoBehaviour {

    Text highscore;
    GameObject highscoreElement;
    int currenthighscore;

    void Start()
    {
        highscoreElement = GameObject.Find("Highscore");
        highscore = highscoreElement.GetComponent<Text>();
        currenthighscore = PlayerPrefs.GetInt("highscore");
        WriteHighscore();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("arena");
        }
    }

    void WriteHighscore() {
        if(currenthighscore == 0) {
            highscoreElement.SetActive(false);
        } else {
            highscoreElement.SetActive(true);
            highscore.text = "Highscore: " + currenthighscore.ToString();
        }
    }
}
