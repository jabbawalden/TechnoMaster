using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResonatorAttack : MonoBehaviour
{
    ResonatorChecks resonatorChecks;
    OnVisibleToPlayer onVisibleToPlayer;
    ResonatorMainController resonatorMainController;

    [SerializeField] GameObject resonatorProjectile;
    ResonatorProjectile projectileClass;

    GameObject player;

    float newTime;
    float minRate = 1.8f;
    float maxRate = 2.5f;
    float minDistance = 0.8f;

    // Start is called before the first frame update
    void Awake()
    {
        onVisibleToPlayer = GetComponentInChildren<OnVisibleToPlayer>();
        resonatorChecks = GetComponent<ResonatorChecks>();
        resonatorMainController = GetComponent<ResonatorMainController>();
    }

    private void Start()
    {
        player = GameObject.Find("PlayerController");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (onVisibleToPlayer.GetPlayer() != null)
        {
            resonatorMainController.DistanceCheck();
            //print("distance to player: " + resonatorMainController.DistanceCheck());

            if (resonatorMainController.DistanceCheck() <= minDistance)
            {
                Attack();
            }
        }
        else
        {

        }
    }

    //private void OnDrawGizmos()
    //{
    //    player = GameObject.Find("PlayerController");
    //    Vector2 lineDirection = (player.transform.position - transform.position).normalized;
    //    Gizmos.DrawLine(transform.position, lineDirection * 100f);
    //}

    void Attack()
    {
        if (newTime <= Time.time)
        {
            float randomRate = Random.Range(minRate, maxRate);
            newTime = Time.time + randomRate;
            resonatorChecks.bActivatingAttack = true;

            GameObject currentProjectile = Instantiate(resonatorProjectile, transform.position, transform.rotation);
            projectileClass = currentProjectile.GetComponent<ResonatorProjectile>();

            projectileClass.moveDirection = (player.transform.position - transform.position).normalized;
            print("attack fired");
        }
    }
}
