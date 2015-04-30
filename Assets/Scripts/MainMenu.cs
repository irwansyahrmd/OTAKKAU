using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    void OnMouseDown()
    {
        Application.LoadLevel("GamePlay");
    }
}
