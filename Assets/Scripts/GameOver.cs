using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private int tapCount, skor;
	public Text score;

	void Awake () {
        tapCount = 0;
		score.text = "" + PlayerPrefs.GetInt("Score");
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetMouseButtonDown(0))
        {
            tapCount++;
            if (tapCount >= 2)
            {
                Application.LoadLevel("GamePlay");
            }
        }
	}
}
