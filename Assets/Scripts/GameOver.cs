using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    private int tapCount;

	void Awake () {
        tapCount = 0;
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
