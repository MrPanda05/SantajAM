using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    [SerializeField] private GameObject DeathScreen, FailScreen;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("Destroying duplicate of Menu manager");
            Destroy(this);
        }
        else
        {
            Debug.Log("Setting Menu manager");
            Instance = this;
        }
    }
    private void OnEnable()
    {
        PlayerDeath.OnPlayerDeath += OpenDeathScreen;
    }
    private void OnDisable()
    {
        PlayerDeath.OnPlayerDeath -= OpenDeathScreen;
    }

    /// <summary>
    /// Open death screen and fail screen
    /// </summary>
    public void OpenDeathScreen()
    {
        if (DeathScreen != null && FailScreen != null)
        {
            if (GameManager.Instance.configs.lives >= 0 && GameManager.Instance.configs.isDead)
            {
                DeathScreen.SetActive(true);
                Debug.Log("Death, respawning");
            }
            else
            {
                FailScreen.SetActive(true);
                Debug.Log("You fail cringekkkkkk");
            }
        }
    }

   
}
