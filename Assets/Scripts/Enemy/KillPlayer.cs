using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    //Kills player on enemy colision
    //TODO change to trigger so the enemies can pass through each other

    public static event Action OnPlayerHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("KillPlayer"))
        {
            if (!GameManager.Instance.configs.isDead)
            {
                Debug.Log("Kill player");
                OnPlayerHit?.Invoke();
            }
        }
    }
}
