using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
    // This script is placed on a projectile GameObject

    public GameObject explosion;
    void Start()
    {
        // The projectile is deleted after 10 seconds, whether
        // or not it collided with anything (to prevent lost
        // instances sticking around in the scene forever)
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // It hit something: create an explosion
        Instantiate(explosion, transform.position, transform.rotation);

        // If you don't want to destroy the projectile, remove the line below:
        // Destroy(gameObject);
    }
}
