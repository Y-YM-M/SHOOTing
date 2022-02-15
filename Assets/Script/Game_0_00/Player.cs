using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int Speed;
    Rigidbody2D rb;

    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * Speed;
        gameObject.transform.position = new Vector3(-2,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,10);
    }
}
