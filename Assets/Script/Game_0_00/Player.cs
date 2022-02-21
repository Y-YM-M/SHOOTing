using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<(string,float,int)> FoodPool=new List<(string,float,int)>();

    /*[SerializeField]//いったん
    private GameObject PlayerBullet;*/
    [SerializeField]
    private Sprite spr0;
    [SerializeField]
    private Sprite spr1;
    int num;
    GameObject MyPlayerBullet;
    Rigidbody2D rb;

    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
        FoodPool.Add(("NormalBullet",10f,-1));
    }

    void Update()
    {
        /*string lg="";
        foreach((string st,float num0,int num1) in FoodPool)
        {
            lg+=st+","+num0+","+num1+"//";
        }
        Debug.Log(lg);*/
        
        rb.AddForce( new Vector3(0,(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y)*Time.deltaTime*1000,0));
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite=spr1;
            //弾の生成
            num=Random.Range(0,FoodPool.Count);
            MakeBullet();
            FoodPool[num]=(FoodPool[num].Item1,FoodPool[num].Item2,FoodPool[num].Item3-1);
            if(FoodPool[num].Item3==0)
            {
                FoodPool.RemoveAt(num);
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite=spr0;
        }
    }
    void MakeBullet()
    {
        if(FoodPool[num].Item1=="NormalBullet")
        {
            MyPlayerBullet=Instantiate((GameObject)Resources.Load(FoodPool[num].Item1), gameObject.transform.position, Quaternion.identity);
            MyPlayerBullet.GetComponent<PlayerBullet>().ATK=FoodPool[num].Item2;
            MyPlayerBullet.GetComponent<Rigidbody2D>().AddForce(new Vector3((Camera.main.ScreenToWorldPoint(Input.mousePosition).x-transform.position.x),(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y),0).normalized*1000);
            MyPlayerBullet.GetComponent<Rigidbody2D>().angularVelocity = Mathf.PI*(Random.Range(0,400)-200);
        }
        else if(FoodPool[num].Item1=="FireBullet")
        {
            MyPlayerBullet=Instantiate((GameObject)Resources.Load(FoodPool[num].Item1), gameObject.transform.position, Quaternion.identity);
            MyPlayerBullet.GetComponent<PlayerBullet>().ATK=FoodPool[num].Item2*3.0f;
            MyPlayerBullet.GetComponent<Rigidbody2D>().AddForce(new Vector3((Camera.main.ScreenToWorldPoint(Input.mousePosition).x-transform.position.x),(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y),0).normalized*1000);
        }
        else if(FoodPool[num].Item1=="WaterBullet")
        {
            MyPlayerBullet=Instantiate((GameObject)Resources.Load(FoodPool[num].Item1), gameObject.transform.position, Quaternion.identity);
            MyPlayerBullet.GetComponent<PlayerBullet>().ATK=FoodPool[num].Item2*1.0f;
            MyPlayerBullet.GetComponent<Rigidbody2D>().AddForce(new Vector3((Camera.main.ScreenToWorldPoint(Input.mousePosition).x-transform.position.x),(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y),0).normalized*1000);
            MyPlayerBullet.GetComponent<Rigidbody2D>().angularVelocity = Mathf.PI*(Random.Range(0,400)-200);
        }
        else if(FoodPool[num].Item1=="WindBullet")
        {
            MyPlayerBullet=Instantiate((GameObject)Resources.Load(FoodPool[num].Item1), gameObject.transform.position, Quaternion.identity);
            MyPlayerBullet.GetComponent<PlayerBullet>().ATK=FoodPool[num].Item2*2.0f;
            MyPlayerBullet.GetComponent<Rigidbody2D>().AddForce(new Vector3((Camera.main.ScreenToWorldPoint(Input.mousePosition).x-transform.position.x),(Camera.main.ScreenToWorldPoint(Input.mousePosition).y-transform.position.y),0).normalized*1000);
            MyPlayerBullet.GetComponent<Rigidbody2D>().angularVelocity = Mathf.PI*(Random.Range(0,200)-300);
        }
    }
}
