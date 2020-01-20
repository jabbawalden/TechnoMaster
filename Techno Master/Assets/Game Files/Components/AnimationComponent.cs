using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationState {Idle, Move, Attack, Death, SpecialAbility1, SpecialAbility2}

public class AnimationComponent : MonoBehaviour
{
    [SerializeField] SpriteRenderer ourRenderer;

    public AnimationState animState;

    private AnimationState lastAnimState;

    Sprite[] lastSpriteArray;

    float NewAnimTime;

    float AnimRate;

    int frameCount;

    public delegate void NextFrame();
    public NextFrame NextFrameDelegate;

    //public delegate void SetLastSpriteArray();
    //public SetLastSpriteArray SetLastSpriteArrayDelegate;

    bool bIsLooping;

    public virtual void Start()
    {
        ourRenderer = GetComponent<SpriteRenderer>();

        if (!ourRenderer)
            ourRenderer = gameObject.AddComponent<SpriteRenderer>(); 

        AnimRate = 0.3f; 
    }

    public virtual void Update()
    {
        CheckFrameChange();
    }

    private void CheckFrameChange()
    {
        if (ourRenderer)
        {
            if (NewAnimTime <= Time.time)
            {
                NewAnimTime = Time.time + AnimRate;
                NextFrameDelegate?.Invoke();
            }
        }
    }

    public void IterateThroughFrames(Sprite[] spriteArray)
    {
        if (bIsLooping)
        {
            if (frameCount <= spriteArray.Length - 1)
            {
                ourRenderer.sprite = spriteArray[frameCount];
                print("frame count is: " + frameCount);
            }
            else
            {
                frameCount = 0;
                ourRenderer.sprite = spriteArray[frameCount];
                print("frame count is: " + frameCount);
            }

            frameCount++;
        }
        else
        {
            if (frameCount <= spriteArray.Length - 1)
            {
                ourRenderer.sprite = spriteArray[frameCount];
                print("frame count is: " + frameCount);

                frameCount++;
            }
            else
            {
                ReturnAnimationState();
                NextFrameDelegate?.Invoke();
            }
        }
    }

    public void ChangeAnimationState(AnimationState newAnimState, bool bShouldLoop)
    {
        frameCount = 0;
        lastAnimState = animState;
        animState = newAnimState;
        bIsLooping = bShouldLoop;

        //if (bIsLooping)
        //    SetLastSpriteArrayDelegate?.Invoke();
    }

    public void ReturnAnimationState()
    {
        frameCount = 0;
        animState = lastAnimState;
        bIsLooping = false;
    }
}
