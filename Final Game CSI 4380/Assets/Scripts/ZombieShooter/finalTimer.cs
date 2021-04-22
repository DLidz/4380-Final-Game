using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finalTimer : MonoBehaviour
{
    public static timer t = new timer();
    [SerializeField] Text txt; 
    // Start is called before the first frame update
    void Start()
    {
        float tt = t.getTime();
        if (tt > HighScores.ZombieShooterHighScore)
            HighScores.ZombieShooterHighScore = tt;
        txt.text = tt.ToString();
        Debug.Log(tt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
