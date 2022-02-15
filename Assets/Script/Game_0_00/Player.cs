using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<(string,float,int)> FoodPool=new List<(string,float,int)>();

    [SerializeField]//いったん
    private GameObject PlayerBullet;
    [SerializeField]
    private int Speed;
    Rigidbody2D rb;
    GameObject MyPlayerBullet;

    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
        FoodPool.Add(("Normal",1.0f,-1));
    }

    void Update()
    {
        //gameObject.transform.position = new Vector3(-8.3f,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,10f);
        rb.AddForce( new Vector3(0,(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y)*Time.deltaTime*1000,0));
        if(Input.GetMouseButtonDown(0))
        {
            MyPlayerBullet=Instantiate(PlayerBullet, gameObject.transform.position, Quaternion.identity);
            MyPlayerBullet.GetComponent<Rigidbody2D>().AddForce(new Vector3((Camera.main.ScreenToWorldPoint(Input.mousePosition).x-transform.position.x),(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y),0).normalized*1000);
        }
    }
}
