using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float bulletSpeed = 100.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.up*Time.deltaTime*bulletSpeed);

        DestroyBullet();
    }

    private void DestroyBullet()
    {
        if (transform.position.z > 50 )
        {
            Destroy(gameObject);
        }
    }
}
