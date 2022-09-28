using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private int enemyHP;
    private void Start()
    {
        enemyHP = 50;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Bullet(Clone)")
        {
            Debug.Log("Попадание! Осталось ХП " + enemyHP);

            if (enemyHP>0)
            {
                enemyHP-=26;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }

    }
}
