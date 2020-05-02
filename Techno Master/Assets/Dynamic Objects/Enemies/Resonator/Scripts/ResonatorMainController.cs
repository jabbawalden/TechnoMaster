using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResonatorMainController : MonoBehaviour
{
    OnVisibleToPlayer onVisibleToPlayer;
    ResonatorChecks resonatorChecks;



    // Start is called before the first frame update
    void Awake()
    {
        onVisibleToPlayer = GetComponentInChildren<OnVisibleToPlayer>();
        resonatorChecks = GetComponent<ResonatorChecks>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onVisibleToPlayer.GetPlayer() != null)
        {
            MoveResonator();
        }
        else
        {

        }
    }

    public float DistanceCheck()
    {
        if (onVisibleToPlayer.GetPlayer() == null)
            return 0f;

        float distance = Vector2.Distance(onVisibleToPlayer.GetPlayer().transform.position, transform.position);
        return distance;
    }

    void MoveResonator()
    {
        if (resonatorChecks.bIsMoving)
        {
            //print("Resonator is MOVING");
        }
        else
        {
            //print("resonator is STILL");
        }
    }
}
