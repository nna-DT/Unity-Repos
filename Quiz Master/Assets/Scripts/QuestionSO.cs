using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)] 
    [SerializeField] string question = "Enter new question here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }
    public int GetcorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
    public string GetAnswers(int index)
    {
        return answers[index];
    }
}
