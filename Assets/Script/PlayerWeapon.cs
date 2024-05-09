using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Assign your bullet prefab in the Unity editor
    public float shootForce = 10f; // Adjust the shooting force as needed

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetButtonDown("Fire1")) // "Fire1" is the default input for left mouse button
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate a bullet prefab at the position and rotation of the player
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        // Get the Rigidbody component of the bullet prefab
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Apply force to the bullet in the forward direction of the player
            rb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Bullet prefab does not have a Rigidbody component!");
        }
    }
}

