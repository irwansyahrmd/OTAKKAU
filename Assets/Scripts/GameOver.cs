using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private int tapCount, finalScore, highScore;
	public Text scoreLabel, textDescriptionLabel, answerLabel;
	public AudioClip gameOverSound;
	public AudioSource gameOverAudioSource;

    public global::GamePlay GamePlay
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

	public void Start(){
		gameOverAudioSource = GetComponent<AudioSource> ();
		gameOverAudioSource.PlayOneShot (gameOverSound);
		answerLabel.text = PlayerPrefs.GetString ("Correct Answer");
		finalScore = PlayerPrefs.GetInt ("Score");
		scoreLabel.text = "" + finalScore;
		tapCount = 0;
		if (PlayerPrefs.HasKey ("High Score")) {
			highScore = PlayerPrefs.GetInt("High Score");
		} else {
			highScore = 0;
		}
	}
	
	public void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

		if (finalScore > highScore) {
			textDescriptionLabel.text = "NEW HIGH SCORE!!!";
			PlayerPrefs.SetInt("High Score", finalScore);
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
