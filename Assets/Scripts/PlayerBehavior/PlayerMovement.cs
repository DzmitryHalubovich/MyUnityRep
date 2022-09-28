using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovementLogic();
        InvisibleWall();
    }

    private void MovementLogic()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        //rb.AddForce(moveDirection*speed);

        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        transform.Translate(Vector3.forward*verticalInput*Time.deltaTime*speed);
    }

    private void InvisibleWall()
    {
        if (transform.position.x <-40)
        {
            float currentPositionY = transform.position.y;
            float currentPositionZ = transform.position.z;

            transform.position = new Vector3(-40, currentPositionY, currentPositionZ);
        }
        if (transform.position.x > 40)
        {
            float currentPositionY = transform.position.y;
            float currentPositionZ = transform.position.z;

            transform.position = new Vector3(40, currentPositionY, currentPositionZ);
        }
        if (transform.position.z < -65)
        {
            float cureentPositionX = transform.position.x;
            float cureentPositionY = transform.position.y;

            transform.position = new Vector3(cureentPositionX,cureentPositionY, -65);
        }

    }
}
