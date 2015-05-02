using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;

public class GamePlay : MonoBehaviour
{
    public Text attText, time, questionText, score, answerText, blueButton, greenButton, pinkButton, yellowButton;
    private float timer;
	public AudioClip wrong, correct;
	AudioSource audio;
	private int skor, attempt;
    private bool isTimeOut;
    private string ch, answer, attext;
    private List<int> indexBlankChar;
    private ChoiceGenerator choice = new ChoiceGenerator();
    private RandomTextQuestionGenerator randomTextQuestion = new RandomTextQuestionGenerator();
    private string blankAnswer;
	public bool isWait, playAudio;

    void Start()
    {
        skor = 0;
		attempt = 3;
		isWait = playAudio = true;
		attext = attText.text;
		attText.text = attext + attempt;
		audio = GetComponent<AudioSource>();
    }

    void Awake()
    {
        timer = 10f;
        isTimeOut = false;
        getNewQuestion();
    }

    void Update()
    {
        changePointer();
        updateTimer();
        checkTimeOut();
        isGameOver();
        loadAnswerButtons();
        if (answerText.text.Equals(answer))
        {
			if (playAudio){
				audio.PlayOneShot(correct);
				playAudio = false;
			}
			if(isWait){
				StartCoroutine(Wait());
			} else {
				getNewQuestion();
				addPoint();
				expandTime();
				playAudio = true;
			}
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MainMenu");
        }

        isAnswerButtonHit();

    }

	private IEnumerator Wait(){
		yield return new WaitForSeconds( 1.0f );
		isWait = false;
	}

    private void isAnswerButtonHit()
    {
		isWait = true;
		if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            if (hitInfo)
            {
                switch (hitInfo.transform.gameObject.name)
                {
                    case "buttonBlue":
                        if (blueButton.text.Equals("" + answer[indexBlankChar[0]]))
                        {
                            nextChar();
                            changePointer();
                        } else {
							audio.PlayOneShot(wrong);
							attempt--;
							attText.text = attext + attempt;
						}
                        break;
                    case "buttonGreen":
                        if (greenButton.text.Equals("" + answer[indexBlankChar[0]]))
                        {
                            nextChar();
                            changePointer();
						} else {
							audio.PlayOneShot(wrong);
							attempt--;
							attText.text = attext + attempt;
						}
                        break;
                    case "buttonPink":
                        if (pinkButton.text.Equals("" + answer[indexBlankChar[0]]))
                        {
                            nextChar();
                            changePointer();
						} else {
							audio.PlayOneShot(wrong);
							attempt--;
							attText.text = attext + attempt;
						}
                        break;
                    case "buttonYellow":
                        if (yellowButton.text.Equals("" + answer[indexBlankChar[0]]))
                        {
                            nextChar();
                            changePointer();
						} else {
							audio.PlayOneShot(wrong);
							attempt--;
							attText.text = attext + attempt;
						}
                        break;
                    default:
                        Debug.Log("No button has been clicked");
                        break;
                }
            }
        }
    }

    private void changePointer()
    {
        if (indexBlankChar.Count > 0)
        {
            StringBuilder sb = new StringBuilder(blankAnswer.Substring(0, indexBlankChar[0]));
            sb.Append("<color=\"#EC87C0\">_</color>");
            sb.Append(blankAnswer.Substring(indexBlankChar[0] + 1));
            answerText.text = sb.ToString();
        }
    }

    private void expandTime()
    {
        timer += 5;
    }

    private void getNewQuestion()
    {
        TextQuestion textQuestion = randomTextQuestion.getRandomTextQuestion();
        answer = textQuestion.getAnswer();
        AnswerGenerator answerGenerator = new AnswerGenerator(answer);
        questionText.text = textQuestion.getQuestion();
        blankAnswer = answerGenerator.getUncompleteAnswer(3);
        answerText.text = blankAnswer;
        indexBlankChar = answerGenerator.getIndexBlankChar();
        ch = choice.getChoice(answer[indexBlankChar[0]]);
        Debug.Log(answer);
    }

    private void nextChar()
    {
        StringBuilder replaceAns = new StringBuilder(blankAnswer);
        replaceAns[indexBlankChar[0]] = answer[indexBlankChar[0]];
        blankAnswer = replaceAns.ToString();
        answerText.text = blankAnswer;
        indexBlankChar.RemoveAt(0);
        if (indexBlankChar.Count > 0)
        {
            ch = choice.getChoice(answer[indexBlankChar[0]]);
        }
    }

    private void isGameOver()
    {
        if (isTimeOut || attempt == 0)
        {
            PlayerPrefs.SetInt("Score", skor);
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

    private void addPoint()
    {
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

    private void loadAnswerButtons()
    {
        blueButton.text = "" + ch[0];
        greenButton.text = "" + ch[1];
        pinkButton.text = "" + ch[2];
        yellowButton.text = "" + ch[3];
    }

}
