using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;

public class GamePlay : MonoBehaviour
{
    public Text time, questionText, score, answerText, blueButton, greenButton, pinkButton, yellowButton;
    private float timer;
	private int skor;
    private bool isTimeOut;
	private string ch, answer;
    private List<int> indexBlankChar;
    private ChoiceGenerator choice = new ChoiceGenerator();
    private RandomTextQuestionGenerator randomTextQuestion = new RandomTextQuestionGenerator();

	void Start(){
		skor = 0;
	}

    void Awake()
    {
        timer = 10f;
        isTimeOut = false;
		getNewQuestion ();
        Debug.Log(answer[indexBlankChar[0]]);
        //StringBuilder sb = new StringBuilder(answer);
        //sb[indexBlankChar[0]] = '*';
        //answer = sb.ToString();

    }

    void Update()
    {
        updateTimer();
        checkTimeOut();
        isGameOver();
        loadAnswerButtons();
		if (answerText.text.Equals (answer)) {
			getNewQuestion();
			addPoint();
			expandTime();
		}

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
					if(blueButton.text.Equals(""+answer[indexBlankChar[0]])){
							nextChar();
						}
                        break;
                    case "buttonGreen":
					if(greenButton.text.Equals(""+answer[indexBlankChar[0]])){
						nextChar();
						}    
					Debug.Log("GREEN");
                        break;
                    case "buttonPink":
					if(pinkButton.text.Equals(""+answer[indexBlankChar[0]])){
						nextChar();
						}
					Debug.Log("PINK");
                        break;
                    case "buttonYellow":
					if(yellowButton.text.Equals(""+answer[indexBlankChar[0]])){
						nextChar();
						}
					Debug.Log("YELLOW");
                        break;
                    default:
                        Debug.Log("No button has been clicked");
                        break;
                }
            }
        }
    }

	private void expandTime (){
		timer += 5;
	}

	private void getNewQuestion(){
		TextQuestion textQuestion = randomTextQuestion.getRandomTextQuestion();
		answer = textQuestion.getAnswer();
		AnswerGenerator answerGenerator = new AnswerGenerator(answer);
		questionText.text = textQuestion.getQuestion();
		answerText.text = answerGenerator.getUncompleteAnswer(3);
		indexBlankChar = answerGenerator.getIndexBlankChar();
		ch = choice.getChoice(answer[indexBlankChar[0]]);
	}

	private void nextChar(){
		StringBuilder replaceAns = new StringBuilder(answerText.text);
		replaceAns [indexBlankChar [0]] = answer [indexBlankChar [0]];
		answerText.text = replaceAns.ToString();
		indexBlankChar.RemoveAt(0);
		ch = choice.getChoice(answer[indexBlankChar[0]]);
	}

    private void isGameOver()
    {
        if (isTimeOut)
        {
			PlayerPrefs.SetInt("Score",skor);
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

	private void addPoint(){
		skor += 10;
		score.text = "" + skor;
	}

    private void updateTimer()
    {
        if (Time.timeSinceLevelLoad >= 1 && !isTimeOut)
        {
            timer -= Time.deltaTime;
            time.text = ((int)timer).ToString();
        }
    }

    private void checkAnswer(string answerChar)
    {

    }

    private void loadAnswerButtons()
    {
        blueButton.text = "" + ch[0];
        greenButton.text = "" + ch[1];
        pinkButton.text = "" + ch[2];
        yellowButton.text = "" + ch[3];
    }

}
