using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimComp_ResonatorAttack : AnimationComponent
{
    [SerializeField] Sprite[] IdleSet;

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
        switch (animState)
        {
            case AnimationState.Idle:
                IterateThroughFrames(IdleSet);
                break;

            case AnimationState.Attack:
                IterateThroughFrames(AttackSet);
                break;
        }
    }
}
