using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Signals : MonoBehaviour
{
    public int index;


    public void ChangeScene()
    {
        GameManager.Instance.HardResetPlayerStats();
        MusicManager.Instance.PlayMusic();
        SceneManager.LoadScene(index);
    }
}
