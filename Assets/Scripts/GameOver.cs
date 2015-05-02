using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private int tapCount, skor, highScore;
	public Text score, textDesc, answer;
	public AudioClip gameover;
	public AudioSource audio;

	void Start(){
		audio = GetComponent<AudioSource> ();
		audio.PlayOneShot (gameover);
		answer.text = PlayerPrefs.GetString ("Correct Answer");
		skor = PlayerPrefs.GetInt ("Score");
		score.text = "" + skor;
		tapCount = 0;
		if (PlayerPrefs.HasKey ("High Score")) {
			highScore = PlayerPrefs.GetInt("High Score");
		} else {
			highScore = 0;
		}
	}

	void Awake () {
        
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

		if (skor > highScore) {
			textDesc.text = "NEW HIGH SCORE!!!";
			PlayerPrefs.SetInt("High Score", skor);
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
