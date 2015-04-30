using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class RandomTextQuestionGenerator
{
    private List<TextQuestion> listTextQuestions;
    public RandomTextQuestionGenerator()
    {
        listTextQuestions = new List<TextQuestion>();
        testInitializedQuestion();
    }

    public TextQuestion getRandomTextQuestion()
    {
        int randomIndex = (int)Random.Range(0, listTextQuestions.Count);
        TextQuestion textQuestion = listTextQuestions[randomIndex];
        //listTextQuestions.RemoveAt(randomIndex);
        return textQuestion;
    }

    public void addTextQuestion(TextQuestion textQuestion)
    {
        listTextQuestions.Add(textQuestion);
    }

    public void testInitializedQuestion()
    {
        addTextQuestion(new TextQuestion("Gunung tertinggi di dunia?", "E v e r e s t".ToUpper()));
        addTextQuestion(new TextQuestion("Siapa founder Facebook.com ?", "M a r k  Z u c k e r b e r g".ToUpper()));
        addTextQuestion(new TextQuestion("Siapa presiden Indonesia ke - 20 ?", "S o e h a r t o".ToUpper()));
    }
}

