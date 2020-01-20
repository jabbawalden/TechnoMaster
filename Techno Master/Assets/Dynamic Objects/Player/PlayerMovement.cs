using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    AnimationComponent animComponent;

    // Start is called before the first frame update
    void Start()
    {
        animComponent = GetComponentInChildren<AnimationComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        /*** ANIMATION STATE CHANGE TEST ***/
        if (!animComponent)
        {
            print("no anim comp found");
            return;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animComponent.ChangeAnimationState(AnimationState.Idle, true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animComponent.ChangeAnimationState(AnimationState.Move, false);
        }
    }
}
