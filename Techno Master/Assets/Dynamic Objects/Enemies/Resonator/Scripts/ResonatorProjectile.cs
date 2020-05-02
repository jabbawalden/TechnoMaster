using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResonatorProjectile : MonoBehaviour
{
    public float moveSpeed = 30f;
    public float damage = 20f;

    public Vector2 moveDirection;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = (moveDirection * moveSpeed) * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

        if (playerHealth == null)
            return;

        playerHealth.AdjustHealth(damage);
    }
}
