using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static int score = 0;
    private Text scoreUI;

    private void Start() {
        scoreUI = GameObject.Find("Score").GetComponent<Text>();
        score = 0;
    }

    private void Update() {
        scoreUI.text = score.ToString();
    }
}
