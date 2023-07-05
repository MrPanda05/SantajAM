using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLRmove : MonoBehaviour
{
    //Move enemies left to right
    private Rigidbody2D[] rg;
    private SpriteRenderer sprite;

    private bool isRight = true;

    [Header("Vars")]
    [SerializeField] private float speed;

    private void Awake()
    {
        rg = GetComponentsInChildren<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void LateUpdate()
    {
        if (rg[0] != null && rg[1] != null)
        {
            sprite.transform.position = rg[0].transform.position;
            rg[1].transform.localPosition = rg[0].transform.localPosition;
        }
    }

    public void Flip()
    {
        isRight = !isRight;
    }
    private void Move()
    {
        if (rg[0] == null)
        {
            return;
        }
        if (isRight)
        {
            rg[0].velocity = Vector2.right * speed;
            sprite.flipX = false;
        }
        else
        {
            rg[0].velocity = Vector2.left * speed;
            sprite.flipX = true;
        }
    }
}
