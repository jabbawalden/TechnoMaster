using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    GameObject player;

    PlayerInput playerInput;

    Vector3 newPosition;

    [SerializeField] float smoothTime;

    float smoothXCam;
    float smoothYCam;

    float smoothXForward;
    float smoothYForward;

    float zOffset = -10f;

    float velocity = 0.0f;

    [SerializeField] float forwardOffsetAmount;


    private void Awake()
    {
        player = GameObject.Find("PlayerController");
        playerInput = player.GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        smoothXCam = Mathf.Lerp(transform.position.x, player.transform.position.x, smoothTime);
        smoothYCam = Mathf.Lerp(transform.position.y, player.transform.position.y, smoothTime);

        newPosition = new Vector3(smoothXCam, smoothYCam, zOffset);

        Vector3 NewForwardOffset = playerInput.move * forwardOffsetAmount;

        smoothXForward = Mathf.Lerp(transform.position.x, NewForwardOffset.x, smoothTime);
        smoothYForward = Mathf.Lerp(transform.position.y, NewForwardOffset.y, smoothTime);

        Vector3 SmoothForwardOffset = new Vector3(smoothXForward, smoothYForward, zOffset);

        transform.position = newPosition + NewForwardOffset;
    }
}
