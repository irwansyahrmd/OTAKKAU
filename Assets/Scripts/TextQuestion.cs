﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TextQuestion
{
    private String question;
    private String answer;

    public TextQuestion(String question, String answer)
    {
        this.question = question.ToUpper();
        this.answer = answer.ToUpper();
    }

    public String GetQuestion()
    {
        return question;
    }

    public String GetAnswer()
    {
		return InsertSpace(answer);
    }

	public String GetNormAnswer()
	{
		return answer;
	}

    private string InsertSpace(string text)
    {
        String newText = "";
        for (int i = 0; i < text.Length-1; i++)
        {
            newText += text[i] + " ";
        }
        newText += text[text.Length - 1];
        return newText;
    }
}
