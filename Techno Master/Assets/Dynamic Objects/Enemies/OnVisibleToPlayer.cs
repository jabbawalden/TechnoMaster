using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnVisibleToPlayer : MonoBehaviour
{
    GameObject Player;

    private void OnBecameVisible()
    {
        Player = GameObject.Find("PlayerController");
    }

    private void OnBecameInvisible()
    {
        Player = null;
    }

    public GameObject GetPlayer()
    {
        if (Player == null)
            return null;

        return Player;
    }
}
