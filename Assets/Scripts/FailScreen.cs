using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class FailScreen : MonoBehaviour
{
    public void RetryGame()
    {
        GameManager.Instance.HardResetPlayerStats();
        SceneManager.LoadScene(2);//Scene of the first world

    }

    public void GoToMenu()
    {
        GameManager.Instance.HardResetPlayerStats();
        MusicManager.Instance.StopMusic();
        SceneManager.LoadScene(0);//To menu
    }
}
