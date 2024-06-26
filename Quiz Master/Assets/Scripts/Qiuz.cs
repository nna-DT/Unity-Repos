using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Qiuz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;

    // Start is called before the first frame update
    void Start()
    {
        questionText.text = question.GetQuestion();

        for(int i=0; i< answerButtons.Length;  i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswers(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
