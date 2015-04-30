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

    public string getUncompleteAnswer(int numberOfBlankChar)
    {
        string uncompleteAnswer = answer;
        StringBuilder sb = new StringBuilder(answer);
        for (int i = 0; i < numberOfBlankChar;)
        {
            int randCharPosition = (int)Random.Range(0,answer.Length-1);
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

