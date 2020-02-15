using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    PlayerChecks playerChecks;
    AnimationComponent animComponent;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        playerChecks = GetComponent<PlayerChecks>();
        animComponent = GetComponentInChildren<AnimationComponent>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            if (!playerChecks.bIsMoving && !playerChecks.bIsAttacking)
            {
                playerChecks.bIsMoving = true;
                playerChecks.bIsIdle = false;
                animComponent.ChangeAnimationState(AnimationState.Move, true);
            }
        }
        else if (rb.velocity == Vector2.zero)
        {

            if (!playerChecks.bIsIdle && !playerChecks.bIsAttacking)
            {
                playerChecks.bIsMoving = false;
                playerChecks.bIsIdle = true;
                animComponent.ChangeAnimationState(AnimationState.Idle, true);
            }
        }

    }
}
