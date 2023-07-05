using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerStats configs;
    [SerializeField] Vector2[] spawnLocations;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Debug.Log("Destroying duplicate of game manager");
            Destroy(this);
        }
        else
        {
            Debug.Log("Setting game manager");
            Instance = this;
        }
    }
    
    //Reset all players configs and stats
    //TODO think of a better solution for this// this is for the deathScreen and Failscreen
    public void HardResetPlayerStats()
    {
        configs.taxes = 0;
        configs.maxTaxes = 0;
        configs.lives = 3;
        configs.isDead = false;
        configs.Score = 000;
        configs.HighScore = 000;
        configs.spawnloacation = spawnLocations[0];
    }
    public void SoftResetPlayerStats()
    {
        configs.taxes = configs.maxTaxes;
        configs.Score = configs.HighScore;
    }

    public void SaveStats()
    {
        configs.maxTaxes = configs.taxes;
        configs.HighScore = configs.Score;
    }
    
    
}
