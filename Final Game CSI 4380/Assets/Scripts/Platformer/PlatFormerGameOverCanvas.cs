using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlatFormerGameOverCanvas : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    void Start()
    {
        TimeSpan timespan = TimeSpan.FromSeconds(PlatformerController.timeSurvived);
        scoreText.text = "You survived for " + timespan.ToString("m':'ss");
        if (PlatformerController.timeSurvived > HighScores.PlatformerHighScore)
            HighScores.PlatformerHighScore = PlatformerController.timeSurvived;
    }

    void Update()
    {
        
    }
}
