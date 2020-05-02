using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustHealth(float amount)
    {
        health += amount;

        if (health < 0f)
            health = 0f;

        if (health > maxHealth)
            health = maxHealth;
    }
}
