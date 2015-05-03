using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public void OnMouseDown()
    {
        Application.LoadLevel("GamePlay");
    }
}
