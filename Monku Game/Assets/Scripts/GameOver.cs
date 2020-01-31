using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadGameScene()
    {
        // load the game scene
        SceneManager.LoadScene("Level 1");
    }
}
