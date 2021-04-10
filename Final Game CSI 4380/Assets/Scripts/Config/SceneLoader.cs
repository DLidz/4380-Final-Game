using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    static int currentGameSceneIndex = 0;
    public void LoadMainMenu()
    {
        currentGameSceneIndex = 0;
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadPlatformer()
    {
        if (currentGameSceneIndex == 0)
            SceneManager.LoadScene("PlatformerLandingScene");
        else
        {
            Debug.Log(currentGameSceneIndex);
            SceneManager.LoadScene("PlatformerScene" + currentGameSceneIndex);
        }
            
        currentGameSceneIndex++;
    }
    public void LoadZombieShooter()
    {
        SceneManager.LoadScene("GameSceneZS");
        //if (currentGameSceneIndex == 0)
        //    SceneManager.LoadScene("ZombieShooterLandingScene");
        //else
        //    SceneManager.LoadScene("GameSceneZS" + currentGameSceneIndex);
        //currentGameSceneIndex++;
    }
    public void LoadBreakout()
    {
        if (currentGameSceneIndex == 0)
            SceneManager.LoadScene("BreakoutLandingScene");
        else
            SceneManager.LoadScene("BreakoutScene" + currentGameSceneIndex);
        currentGameSceneIndex++;
    }
    public void LoadRCRacing()
    {
        if (currentGameSceneIndex == 0)
            SceneManager.LoadScene("RCRacingLandingScene");
        else
            SceneManager.LoadScene("RCRacingScene" + currentGameSceneIndex);
        currentGameSceneIndex++;
    }
}
