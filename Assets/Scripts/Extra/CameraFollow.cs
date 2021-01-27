using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [Header("Tools")]
    private GameObject playerGO;
    private Vector2 velocity;

    void Start()
    {
        playerGO = GameObject.Find("Player");
    }

    
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, playerGO.transform.position.x, ref velocity.x, 0.1f);
        float posY = Mathf.SmoothDamp(transform.position.y, playerGO.transform.position.y + 0.25f, ref velocity.y, 0.1f);
        
        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
