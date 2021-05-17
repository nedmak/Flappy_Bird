using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    private string scene = "GameScene";
    private void Start()
    {
        Debug.Log("GameHandler.Start");

        //Score.Start();

        if (scene == SceneManager.GetActiveScene().name)
        {
            Score.Start();
        }
    }
}
