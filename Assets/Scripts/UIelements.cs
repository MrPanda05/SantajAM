using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIelements : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Lives, Score;

    private void Start()
    {
        Lives.text = $"x {GameManager.Instance.configs.lives}";
        if(GameManager.Instance.configs.HighScore == 0)
        {
            Score.text = "000";
        }
        else
        {
            Score.text = $"{GameManager.Instance.configs.HighScore}";
        }
    }

    private void OnEnable()
    {
        KillEnemy.OnEnemyDeath += UpdateTextScore;
        KillPlayer.OnPlayerHit += UpdateTextLive;
    }
    private void OnDisable()
    {
        KillEnemy.OnEnemyDeath -= UpdateTextScore;
        KillPlayer.OnPlayerHit -= UpdateTextLive;
    }

    public void UpdateTextScore()
    {
        if(GameManager.Instance.configs.Score < GameManager.Instance.configs.HighScore)
        {
            GameManager.Instance.configs.Score = GameManager.Instance.configs.HighScore;
        }
        GameManager.Instance.configs.Score += 100;
        Score.text = GameManager.Instance.configs.Score.ToString();
    }
    public void UpdateTextLive()
    {
        if(GameManager.Instance.configs.lives - 1 < 0)
        {
            Lives.text = "x 0";
        }
        else
        {
            Lives.text = $"x {GameManager.Instance.configs.lives}";
        }
    }

}
