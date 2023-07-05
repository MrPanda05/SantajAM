using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    //Kill Enemy on player collision with head

    private Rigidbody2D rg;

    [SerializeField] private float upSpeed;

    public static event Action OnEnemyDeath;

    private void Awake()
    {
        rg = GetComponentInParent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Kill Enemy logic
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Debug.Log("Kill Enemy");
            rg.velocity = Vector2.up * upSpeed;//Jumps the player up so they don't hit the death collider and for feedback
            var gamer = collision.gameObject.GetComponentInParent<EnemyDeath>();
            OnEnemyDeath?.Invoke();
            gamer.StartCoroutine(gamer.Kill());
        }
    }
}
