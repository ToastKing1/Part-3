using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // the scene index
    static int sceneIndex;

    // the amount of flowers that are finished
    static public int flowersFinished = 0;

    // this method swaps the scene and sets the flowers finished to 0 to prevent possible bugs
    public static void ChangeScene()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;


        // if the scene is on the end screen, swap it back to the instructions
        if (sceneIndex == 3)
        {
            sceneIndex = 0;
        }
        flowersFinished = 0;
        SceneManager.LoadScene(sceneIndex);
    }
}
