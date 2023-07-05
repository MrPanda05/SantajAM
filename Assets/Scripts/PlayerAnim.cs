using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAnim : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(PlayerGroundMovement.move.ReadValue<Vector2>() == Vector2.zero)
        {
            anim.Play("Idle");
        }
        else
        {
            anim.Play("Walking");
        }
    }

}
