using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuMethods : MonoBehaviour
{
    [SerializeField] private GameObject Settings, Buttons;

    [SerializeField] private TMP_Dropdown Drop;


    public int index;

    private void Awake()
    {
        Buttons.SetActive(true);
    }
    public void GoToSettings()
    {
        Buttons.SetActive(false);
        Settings.SetActive(true);
    }
    public void GoToBack()
    {
        Settings.SetActive(false);
        Buttons.SetActive(true);
    }

    public void KillGame()
    {
        Application.Quit();
    }
    public void GoToMenu()
    {
        GameManager.Instance.HardResetPlayerStats();
        MusicManager.Instance.StopMusic();
        SceneManager.LoadScene(0);//To menu
    }
    public void GoToScene()
    {
        SceneManager.LoadScene(index);
        MusicManager.Instance.StopMusic();
    }

    public void ChangeResolution()
    {
        if(Drop.value == 0)
        {
            Screen.SetResolution(1366, 768, true);
        }
        else if(Drop.value == 1)
        {
            Screen.SetResolution(640, 360, false);
        }
        else if (Drop.value == 2)
        {
            Screen.SetResolution(896, 504, false);
        }
        else if (Drop.value == 3)
        {
            Screen.SetResolution(1280, 720, true);
        }
        else if (Drop.value == 4)
        {
            Screen.SetResolution(1920, 1080, true);
        }
    }
}
