using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimComp_Player : AnimationComponent
{
    [SerializeField] Sprite[] IdleSet;

    [SerializeField] Sprite[] MoveSet;

    [SerializeField] Sprite[] AttackSet;

    public override void Start()
    {
        base.Start();

        NextFrameDelegate += PlayAnimation;
    }

    public override void Update()
    {
        base.Update();
    }

    void PlayAnimation()
    {
        print("play animation called");

        switch (animState)
        {
            case AnimationState.Idle:
                IterateThroughFrames(IdleSet);
                break;

            case AnimationState.Move:
                IterateThroughFrames(MoveSet);
                break;
        }
    }
}
