using UnityEngine;
using System.Collections;
using System.Text;
using System.Collections.Generic;

public class AnswerGenerator
{
    private string answer;
    private List<int> indexBlankChar;
    public AnswerGenerator(string answer)
    {
        this.answer = answer;
        indexBlankChar = new List<int>();
    }

    public string getUncompleteAnswer()
    {
        string uncompleteAnswer = "";
		int len = answer.Length / 2;
		if (len <= 3) {
			uncompleteAnswer = makeUncompleteAnswer(2);
		} else if (len <= 7) {
			uncompleteAnswer = makeUncompleteAnswer(3);
		} else if (len <= 13) {
			uncompleteAnswer = makeUncompleteAnswer(4);
		} else {
			uncompleteAnswer = makeUncompleteAnswer(5);
		}
        return uncompleteAnswer;
    }

    private string makeUncompleteAnswer(int numberOfBlankChar)
    {
        string uncompleteAnswer = answer;
        StringBuilder sb = new StringBuilder(answer);
        for (int i = 0; i < numberOfBlankChar; )
        {
            int randCharPosition = (int)Random.Range(0, answer.Length);
            if (!sb[randCharPosition].Equals(' ') && !sb[randCharPosition].Equals('_'))
            {
                sb[randCharPosition] = '_';
                indexBlankChar.Add(randCharPosition);
                i++;
            }
        }
        uncompleteAnswer = sb.ToString();
        return uncompleteAnswer;
    }


    public List<int> getIndexBlankChar()
    {
        indexBlankChar.Sort();
        return indexBlankChar;
    }
}

