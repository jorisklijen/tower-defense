using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavourScript : MonoBehaviour
{
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void GetShot(int damage)
    {
        hp = hp - damage;
    }
}
