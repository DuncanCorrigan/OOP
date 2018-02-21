using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    //Hot Keys

        //CLEAN CODE = CRTL + K + D
        //MULTI LINE SELECT = ALT + SHIFT

    //Member Variables
    public float movementSpeed; //declaring a variable
    public float rotationSpeed;

    void Update()
    {
        Movement(); //Call Movement() Function
        Rotation(); //Call Rotation() Function 
        #region AltAsteroidCode
        //check if the user has pressed the up key
        //if(Input.GetKey(KeyCode.UpArrow))
        //{
        //    //move the game object up by a speed
        //    transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        //    //transform.position += Vector3.up * movementSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //move the game object up by a speed
        //transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        //transform.position += Vector3.down * movementSpeed * Time.deltaTime;
        //}

        //check if user has pressed right key
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
        //    transform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.back);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        //    transform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.forward);
        //}
        #endregion
    }
    void Movement()
    {
        Vector3 moveDir = new Vector3(0, Input.GetAxis("Vertical"), 0);
        transform.Translate(moveDir * movementSpeed * Time.deltaTime);
    }
    void Rotation()
    {
        Vector3 rotateDir = new Vector3(0, 0, Input.GetAxis("Horizontal"));
        transform.Rotate(rotateDir, -rotationSpeed * Time.deltaTime);
    }
}
