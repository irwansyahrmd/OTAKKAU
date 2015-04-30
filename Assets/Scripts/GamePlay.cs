using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public Text time, question, answer, c1,c2,c3,c4;
    private float timer;
    private bool isTimeOut;
	private string pil;
	private ChoiceGenerator pilihan = new ChoiceGenerator();

    void Awake()
    {
        timer = 10f;
		pil = pilihan.getChoice ('A');
        isTimeOut = false;
    }

    void Update()
    {
        updateTimer();
        checkTimeOut();
        isGameOver();
		c1.text = ""+pil [0];
		c2.text = ""+pil [1];
		c3.text = ""+pil [2];
		c4.text = ""+pil [3];
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MainMenu");
        }

        isAnswerButtonHit();

    }

    private void isAnswerButtonHit()
    {
        if (Input.GetMouseButtonDown(0))
        {
			Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            if (hitInfo)
            {
                switch (hitInfo.transform.gameObject.name)
                {
                    case "buttonBlue":
                        Debug.Log("BLUE");
						break;
                    case "buttonGreen":
                        Debug.Log("GREEN");
                        break;
                    case "buttonPink":
                        Debug.Log("PINK");
                        break;
                    case "buttonYellow":
                        Debug.Log("YELLOW");
                        break;
                    default:
                        Debug.Log("No button has been clicked");
                        break;
                }
				pil = pilihan.getChoice('A');
            }
        }
    }

    private void isGameOver()
    {
        if(isTimeOut)
        {
            Application.LoadLevel("GameOver");
        }
    }

    private void checkTimeOut()
    {
        if (time.text.Equals("0"))
        {
            isTimeOut = !isTimeOut;
        }
    }

    private void updateTimer()
    {
        if (Time.timeSinceLevelLoad>=1 && !isTimeOut)
        {
            timer -= Time.deltaTime;
            time.text = ((int)timer).ToString();
        }
    }

}
