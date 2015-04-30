using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;

public class GamePlay : MonoBehaviour
{
    public Text time, questionText, answerText, blueButton, greenButton, pinkButton, yellowButton;
    private float timer;
    private bool isTimeOut;
    private string ch;
    private string answer;
    private List<int> indexBlankChar;
    private ChoiceGenerator choice = new ChoiceGenerator();
    private RandomTextQuestionGenerator randomTextQuestion = new RandomTextQuestionGenerator();

    void Awake()
    {
        timer = 10f;
        isTimeOut = false;
        TextQuestion textQuestion = randomTextQuestion.getRandomTextQuestion();
        answer = textQuestion.getAnswer();
        AnswerGenerator answerGenerator = new AnswerGenerator(answer);
        questionText.text = textQuestion.getQuestion();
        answerText.text = answerGenerator.getUncompleteAnswer(4);
        indexBlankChar = answerGenerator.getIndexBlankChar();

        //ch = choice.getChoice('A');
        ch = choice.getChoice(answer[indexBlankChar[0]]);
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
                ch = choice.getChoice('A');
            }
        }
    }

    private void isGameOver()
    {
        if (isTimeOut)
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
