using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [Header("Weapon Info")]
    public GameObject bulletPrefab;
    private int damage;
    private int velocity;
    private int magazineSize;
    private int ammo = 10;



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void Shoot()
    {
        if (ammo == 0)
            return;
        Vector3 cursorInWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = cursorInWorldPos - transform.position;
        direction.Normalize();

        GameObject tmp = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        tmp.GetComponent<Rigidbody2D>().velocity = direction * 10;

        //ammo--;
    }
}
