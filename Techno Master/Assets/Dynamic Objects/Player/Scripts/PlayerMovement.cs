using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerInputComponent;
    PlayerChecks playerChecks;
    Rigidbody2D rb;

    GameObject aimer;

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float aimLerpSpeed = 0.25f;

    [SerializeField] Quaternion aimRotate;

    // Start is called before the first frame update
    void Awake()
    {

        playerInputComponent = GetComponent<PlayerInput>();
        playerChecks = GetComponent<PlayerChecks>();
        rb = GetComponent<Rigidbody2D>();
        aimer = GameObject.Find("Gadget");
    }

    void Update()
    {
        /*** ANIMATION STATE CHANGE TEST ***/




    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        AimRotation();
    }

    void Movement()
    {
        Vector2 newVelocity = playerInputComponent.move * moveSpeed * Time.deltaTime;

        if (rb == null)
            return;

        rb.velocity = newVelocity;
    }

    void AimRotation()
    {
        float aimAngle = Mathf.Atan2(-playerInputComponent.aim.x, playerInputComponent.aim.y) * Mathf.Rad2Deg;

        if (playerInputComponent.aim.x != 0 || playerInputComponent.aim.y != 0)
        {
            Quaternion aimTargetValue = Quaternion.AngleAxis(aimAngle, Vector3.forward);
            Quaternion aimTarget = Quaternion.Slerp(aimer.transform.rotation, aimTargetValue, aimLerpSpeed);
            aimer.transform.rotation = aimTarget;
        }
    }

}
