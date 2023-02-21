using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("mainScene");

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("startScene");

    }

}
