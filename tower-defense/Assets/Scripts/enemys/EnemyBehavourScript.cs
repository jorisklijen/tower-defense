using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavourScript : MonoBehaviour
{
    public int Health = 1;
    bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetShot(int damage)
    {
        Health -= damage;

        if(Health <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Destroy(gameObject);
    }
}
