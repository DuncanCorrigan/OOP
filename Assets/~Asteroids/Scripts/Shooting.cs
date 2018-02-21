using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform[] spawnPoint;

    public float shootRate = 0.5f;
    public float projectileSpeed = 5f;
    public int damage = 20;

    private float shootTimer = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Count up timer
        shootTimer += Time.deltaTime;
        //Check if the timer has reached the shootRate
        if (shootTimer >= shootRate && Input.GetKey(KeyCode.Space)) //Check if timer has reached shootrate AND space is down
        {
            for (int i = 0; i < spawnPoint.Length; i++)
            {
                //Calls the Shoot() function
                Shoot(spawnPoint[i]);

            }
            //Reset timer
            shootTimer = 0f;
        }
    }

    //Logic for shooting a projectile
    void Shoot(Transform point)
    {
        //Instantiate a prefab
        GameObject clone = Instantiate(projectilePrefab);
        //Set position of clone to the player
        clone.transform.position = point.position;
        //Get rigid component 
        Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
        //Apply force
        rigid.AddForce(transform.up * projectileSpeed, ForceMode2D.Impulse);
    }
}
