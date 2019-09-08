using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    Canvas gameOverCanvas;


    void Start() {
        gameOverCanvas = GameObject.Find("GameOverCanvas").GetComponent<Canvas>();
    }

    public void GameOverCall() {

        if (PlayerPrefs.GetInt("highscore") < ScoreController.score) {
            PlayerPrefs.SetInt("highscore", ScoreController.score);
        }
        gameOverCanvas.enabled = true;
    }
}
