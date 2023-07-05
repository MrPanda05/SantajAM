using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{
    //Wall hit detection for enemies to turn around
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("HitWall");
            gameObject.GetComponentInParent<EnemyLRmove>().Flip();
        }
    }
}
