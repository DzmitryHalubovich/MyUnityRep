using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    private float shootDelay = 3.0f;
    private float shootSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", shootDelay, shootSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Vector3 enemyBulletPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z-5);
        Instantiate(enemyBulletPrefab, enemyBulletPosition, enemyBulletPrefab.transform.rotation);
    }

}
