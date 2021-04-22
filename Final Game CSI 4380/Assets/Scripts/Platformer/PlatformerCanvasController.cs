using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlatformerCanvasController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;
    float timeSurvived = 0;
    TimeSpan convertedTime;
    void Update()
    {
        timeSurvived += Time.deltaTime;
        PlatformerController.timeSurvived = timeSurvived;
        convertedTime = TimeSpan.FromSeconds(timeSurvived);
        timerText.text = convertedTime.ToString("m':'ss");

    }
}
