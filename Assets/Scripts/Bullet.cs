using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int damage;
    private Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    void Setup(float velocity, float angle, int damage)
    {
        if (!rb2d)
            rb2d = GetComponent<Rigidbody2D>();

        this.damage = damage;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Wall")
            Destroy(this.gameObject);
    }
}
