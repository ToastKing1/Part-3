using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    static int sceneIndex;

    static public int flowersFinished = 0;
    public static void ChangeScene()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (sceneIndex > SceneManager.sceneCount)
        {
            sceneIndex = 0;
        }
        flowersFinished = 0;
        SceneManager.LoadScene(sceneIndex);
    }
}
