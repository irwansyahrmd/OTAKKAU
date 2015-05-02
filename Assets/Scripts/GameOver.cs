using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private int tapCount, skor, highScore;
	public Text score, textDesc;
	public AudioClip gameover;
	public AudioSource audio;

	void Start(){
		audio = GetComponent<AudioSource> ();
		audio.PlayOneShot (gameover);
		if (PlayerPrefs.HasKey ("High Score")) {
			highScore = PlayerPrefs.GetInt("High Score");
		} else {
			highScore = 0;
		}
	}

	void Awake () {
        tapCount = 0;
		skor = PlayerPrefs.GetInt ("Score");
		score.text = "" + skor;
		if (skor > highScore) {
			textDesc.text = "NEW HIGH SCORE!!!";
		}
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
