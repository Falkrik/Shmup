using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("Player")]
    private const float defaultSpeed = 7.0f;
    private float speed;
    [Space]
    private int maxHealth = 6;  // temporary
    private int curHealth;


    [Header("Tools")]
    private Rigidbody2D rb2d;

    private void Start()
    {
        speed = defaultSpeed;
        curHealth = maxHealth;
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        if (Input.GetMouseButton(0))
            GetComponent<Weapon>().Shoot();
    }

    private void FixedUpdate()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2d.velocity = input * speed;
    }


    public void IncreaseSpeed(float amount)
    {
        speed += amount;
    }
}
