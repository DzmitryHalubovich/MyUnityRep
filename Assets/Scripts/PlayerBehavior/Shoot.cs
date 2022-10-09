using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public ParticleSystem shootParticleEffects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = new Vector3(transform.position.x,transform.position.y,transform.position.z+10);
            Instantiate(bulletPrefab, position, bulletPrefab.transform.rotation);
            shootParticleEffects.Play();
        }
    }
}
