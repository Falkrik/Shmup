using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    private const float defaultVelocity = 7.0f;

    [Header("Tools")]
    private Rigidbody2D rb2d;

    private void Start()
    {
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
        rb2d.velocity = input * defaultVelocity;
    }
}
