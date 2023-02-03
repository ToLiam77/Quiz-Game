using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionSeen = 0;

    public int getCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int getQuestionsSeen()
    {
        return questionSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionSeen * 100);
    }
}
