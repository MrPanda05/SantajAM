using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.SaveStats();
            if(GameManager.Instance.configs.maxTaxes == 0)
            {
                MusicManager.Instance.StopMusic();
                SceneManager.LoadScene(5);//Ancap

            }else if(GameManager.Instance.configs.maxTaxes > 1 && GameManager.Instance.configs.maxTaxes < 18)
            {
                MusicManager.Instance.StopMusic();
                SceneManager.LoadScene(6);//Normal
            }
            else if(GameManager.Instance.configs.maxTaxes == 18)
            {
                MusicManager.Instance.StopMusic();
                SceneManager.LoadScene(7);//PayAll ending
            }
            else
            {
                MusicManager.Instance.StopMusic();
                SceneManager.LoadScene(8);//How?
            }
        }
    }
}
