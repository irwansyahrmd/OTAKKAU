using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;

public class GamePlay : MonoBehaviour
{
    public Text numberOfAttemptLabel, timeLabel, questionLabel, scoreLabel, 
        answerLabel, blueButtonLabel, greenButtonLabel, pinkButtonLabel, 
        yellowButtonLabel;
    public AudioClip wrongSound, correctSound, tapSound;
    public AudioSource gamePlayAudioSource;
    public bool isWait, playAudio;
    private GameTimer gameTimer;
	private int score, numberOfAttempt;
    private bool isTimeOut;
    private string listCharacterForAnswerButton, answer, attemptText;
    private List<int> indexBlankChar;
    private ChoiceGenerator choice = new ChoiceGenerator();
    private RandomTextQuestionGenerator randomTextQuestion = new RandomTextQuestionGenerator();
    private string blankAnswer;

    public void Start()
    {
		score = 0;
		numberOfAttempt = 3;
		isWait = playAudio = true;
		attemptText = numberOfAttemptLabel.text;
		numberOfAttemptLabel.text = attemptText + numberOfAttempt;
		gamePlayAudioSource = GetComponent<AudioSource>();
    }

    public void Awake()
    {
        gameTimer = GameTimer.getInstance();
        gameTimer.currentTime = 10f;
        isTimeOut = false;
        GetNewQuestion();
    }

    public void Update()
    {
        ChangePointer();
        UpdateTimer();
        CheckTimeOut();
        IsGameOver();
        LoadAnswerButtons();
		answerLabel.color = new Color (50f/255, 50f/255, 50f/255);
        if (answerLabel.text.Equals(answer))
        {
			if (playAudio){
				gamePlayAudioSource.PlayOneShot(correctSound);
				playAudio = false;
			}
			if(isWait){
				StartCoroutine(Wait());
			} else {
				GetNewQuestion();
				AddScore();
                gameTimer.addTime(8);
				playAudio = true;
			}
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MainMenu");
        }

        IsAnswerButtonHit();

    }

	private IEnumerator Wait(){
		answerLabel.color = new Color (70f/255, 180f/255, 40f/255);
		yield return new WaitForSeconds( 0.5f );
		isWait = false;
	}

    private void IsAnswerButtonHit()
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
                        if (blueButtonLabel.text.Equals("" + answer[indexBlankChar[0]]))
                        {
							gamePlayAudioSource.PlayOneShot(tapSound);
							MovePointerToNextBlankChar();
                            ChangePointer();
                        } else {
							gamePlayAudioSource.PlayOneShot(wrongSound);
							numberOfAttempt--;
							numberOfAttemptLabel.text = attemptText + numberOfAttempt;
						}
                        break;
                    case "buttonGreen":
                        if (greenButtonLabel.text.Equals("" + answer[indexBlankChar[0]]))
                        {
							gamePlayAudioSource.PlayOneShot(tapSound);    
							MovePointerToNextBlankChar();
                            ChangePointer();
						} else {
							gamePlayAudioSource.PlayOneShot(wrongSound);
							numberOfAttempt--;
							numberOfAttemptLabel.text = attemptText + numberOfAttempt;
						}
                        break;
                    case "buttonPink":
                        if (pinkButtonLabel.text.Equals("" + answer[indexBlankChar[0]]))
                        {
							gamePlayAudioSource.PlayOneShot(tapSound);
							MovePointerToNextBlankChar();
                            ChangePointer();
						} else {
							gamePlayAudioSource.PlayOneShot(wrongSound);
							numberOfAttempt--;
							numberOfAttemptLabel.text = attemptText + numberOfAttempt;
						}
                        break;
                    case "buttonYellow":
                        if (yellowButtonLabel.text.Equals("" + answer[indexBlankChar[0]]))
                        {
							gamePlayAudioSource.PlayOneShot(tapSound);
							MovePointerToNextBlankChar();
                            ChangePointer();
						} else {
							gamePlayAudioSource.PlayOneShot(wrongSound);
							numberOfAttempt--;
							numberOfAttemptLabel.text = attemptText + numberOfAttempt;
						}
                        break;
                    default:
                        Debug.Log("No button has been clicked");
                        break;
                }
            }
        }
    }

    private void ChangePointer()
    {
        if (indexBlankChar.Count > 0)
        {
            StringBuilder sb = new StringBuilder(blankAnswer.Substring(0, indexBlankChar[0]));
            sb.Append("<color=\"#EC87C0\">_</color>");
            sb.Append(blankAnswer.Substring(indexBlankChar[0] + 1));
            answerLabel.text = sb.ToString();
        }
    }

    private void GetNewQuestion()
    {
        TextQuestion textQuestion = randomTextQuestion.GetRandomTextQuestion();
        answer = textQuestion.GetAnswer();
		PlayerPrefs.SetString ("Correct Answer", textQuestion.GetNormAnswer());
        AnswerGenerator answerGenerator = new AnswerGenerator(answer);
        questionLabel.text = textQuestion.GetQuestion();
        blankAnswer = answerGenerator.GetUncompleteAnswer();
        answerLabel.text = blankAnswer;
        indexBlankChar = answerGenerator.GetIndexBlankChar();
        listCharacterForAnswerButton = choice.GetChoice(answer[indexBlankChar[0]]);
        Debug.Log(answer);
    }

    private void MovePointerToNextBlankChar()
    {
        StringBuilder replaceAns = new StringBuilder(blankAnswer);
        replaceAns[indexBlankChar[0]] = answer[indexBlankChar[0]];
        blankAnswer = replaceAns.ToString();
        answerLabel.text = blankAnswer;
        if (indexBlankChar.Count > 0)
        {
			indexBlankChar.RemoveAt(0);
			try{
				listCharacterForAnswerButton = choice.GetChoice(answer[indexBlankChar[0]]);
			}catch{}
        }
    }

    private void IsGameOver()
    {
        if (isTimeOut || numberOfAttempt == 0)
        {
            PlayerPrefs.SetInt("Score", score);
            Application.LoadLevel("GameOver");
        }
    }

    private void CheckTimeOut()
    {
        if (timeLabel.text.Equals("0"))
        {
            isTimeOut = !isTimeOut;
        }
    }

    private void AddScore()
    {
        score += 10;
        scoreLabel.text = "" + score;
    }

    private void UpdateTimer()
    {
        if (Time.timeSinceLevelLoad >= 1 && !isTimeOut)
        {
            gameTimer.currentTime -= Time.deltaTime;
            timeLabel.text = ((int)gameTimer.currentTime).ToString();
        }
    }

    private void LoadAnswerButtons()
    {
        blueButtonLabel.text = "" + listCharacterForAnswerButton[0];
        greenButtonLabel.text = "" + listCharacterForAnswerButton[1];
        pinkButtonLabel.text = "" + listCharacterForAnswerButton[2];
        yellowButtonLabel.text = "" + listCharacterForAnswerButton[3];
    }

}
