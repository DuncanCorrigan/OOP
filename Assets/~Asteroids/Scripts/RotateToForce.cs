using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class RotateToForce : MonoBehaviour
{
    private Rigidbody2D rigid;
    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 force = rigid.velocity;
        //Convert direction to angle in degrees
        float angle = Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg;
        // Rotate transform to angle
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
