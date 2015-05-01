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
        initQuestion();
    }

    public TextQuestion getRandomTextQuestion()
    {
        int randomIndex = (int)Random.Range(0, listTextQuestions.Count-1);
        TextQuestion textQuestion = listTextQuestions[randomIndex];
		listTextQuestions.RemoveAt(randomIndex);
        //listTextQuestions.RemoveAt(randomIndex);
        return textQuestion;
    }

    public void addTextQuestion(TextQuestion textQuestion)
    {
        listTextQuestions.Add(textQuestion);
    }

    public void initQuestion()
    {
        addTextQuestion(new TextQuestion("Gunung tertinggi di dunia", "E v e r e s t".ToUpper()));
        addTextQuestion(new TextQuestion("Founder Facebook.com", "Z u c k e r b e r g".ToUpper()));
        addTextQuestion(new TextQuestion("Presiden Indonesia ke - 2 ?", "S o e h a r t o".ToUpper()));
		addTextQuestion(new TextQuestion("Sebutan kicauan pada twitter", "t w e e t".ToUpper()));
		addTextQuestion(new TextQuestion("Kitab suci umat hindu", "w e d a".ToUpper()));
		addTextQuestion(new TextQuestion("Mata uang Thailand", "b a h t".ToUpper()));
		addTextQuestion(new TextQuestion("Dokter wanita pertama di dunia", "b l a c k w e l l".ToUpper()));
		addTextQuestion(new TextQuestion("Serangga penghasil madu", "l e b a h".ToUpper()));
		addTextQuestion(new TextQuestion("Negara penyelenggara Piala Dunia 2022?", "q a t a r".ToUpper()));
		addTextQuestion(new TextQuestion("Kemampuan bunglon untuk mengubah warna kulit", "m i m i k r i".ToUpper()));
		addTextQuestion(new TextQuestion("Presiden pertama Amerika Serikat", "a b r a h a m  l i n c o l n".ToUpper()));
		addTextQuestion(new TextQuestion("Kota di Jepang yang terkena bom Atom pada PD II", "n a g a s a k i".ToUpper()));
		addTextQuestion(new TextQuestion("Alat musik tradisional Jawa Barat", "a n g k l u n g".ToUpper()));
    }
}

