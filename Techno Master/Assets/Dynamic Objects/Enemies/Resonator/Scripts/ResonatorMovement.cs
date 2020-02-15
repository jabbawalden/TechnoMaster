using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResonatorMovement : MonoBehaviour
{
    OnVisibleToPlayer onVisibleToPlayer;

    // Start is called before the first frame update
    void Awake()
    {
        onVisibleToPlayer = GetComponentInChildren<OnVisibleToPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onVisibleToPlayer.GetPlayer() != null)
        {
            
        }
        else
        {

        }
    }
}
