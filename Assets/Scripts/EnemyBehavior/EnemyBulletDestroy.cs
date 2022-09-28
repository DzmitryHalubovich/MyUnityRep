using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <-100)
        {
            Destroy(gameObject);
        }
    }
}
