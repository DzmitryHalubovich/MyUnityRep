using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float enemySpeed = 10.0f;
    private float stopPosition;
    private bool checkDirection = true;
    // Start is called before the first frame update
    void Start()
    {
        stopPosition = Random.Range(0f, -30.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > stopPosition)
        {
            transform.Translate(Vector3.forward*1*Time.deltaTime*enemySpeed);
        }
        else
        {
            if (transform.position.x > 40)
            {
                checkDirection = false;
            }
            else if (transform.position.x < -40)
            {
                checkDirection = true;
            }
            EnemyPatrolMovement(checkDirection);
        }

    }

    void EnemyPatrolMovement(bool checkDirection)
    {
        if (checkDirection)
        {
            transform.Translate(Vector3.left*Time.deltaTime*enemySpeed);
        }
        else 
        {
            transform.Translate(Vector3.right*Time.deltaTime*enemySpeed);
            
        }
    }
}
