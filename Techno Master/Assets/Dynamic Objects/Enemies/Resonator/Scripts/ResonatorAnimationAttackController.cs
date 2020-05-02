using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResonatorAnimationAttackController : MonoBehaviour
{
    AnimComp_ResonatorAttack animAttackComponent;
    //AnimationComponent animCharacterComponent;
    ResonatorChecks resonatorChecks;

    // Start is called before the first frame update
    void Awake()
    {
        animAttackComponent = GetComponentInChildren<AnimComp_ResonatorAttack>();
        resonatorChecks = GetComponent<ResonatorChecks>();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (resonatorChecks.bActivatingAttack && !resonatorChecks.bIsAttacking)
        {
            resonatorChecks.bIsAttacking = true;
            //for safety measures, add our end attack to delegate, then remove on EndAttack
            animAttackComponent.EndAnimationSequenceDelegate += EndAttack;
            animAttackComponent.ChangeAnimationState(AnimationState.Attack, false);
            print("attack animation started");
        }
        else if (!resonatorChecks.bActivatingAttack)
        {
            animAttackComponent.ChangeAnimationState(AnimationState.Idle, true);
        }
    }

    void EndAttack()
    {
        resonatorChecks.bActivatingAttack = false;
        resonatorChecks.bIsAttacking = false;
        print("EndAttack Delegate Called");
        animAttackComponent.EndAnimationSequenceDelegate -= EndAttack;
    }
}
