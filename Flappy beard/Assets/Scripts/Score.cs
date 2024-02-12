using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    private static int oldScore = 0;
    private TextMeshProUGUI scoreTMP;

    void Start()
    {
        score = 0;
        oldScore = 0;
        scoreTMP = GetComponent<TextMeshProUGUI>();
        scoreTMP.text = score.ToString();
    }

    void FixedUpdate()
    {
        if (score != oldScore)
        {
            scoreTMP.text = score.ToString();
            oldScore = score;
        }
    }
}
