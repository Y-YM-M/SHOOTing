using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float EnemyLv;
    public float HP;

    [SerializeField]
    private GameObject Food;
    float MaxHP;
    float LastHP;
    GameObject go;
    Transform tf;

    void Start()
    {
        tf=GameObject.Find("Advancer").transform;

        //Debug.Log(Mathf.Pow(1.03f, EnemyLv)*15);
        HP=Mathf.Pow(1.03f, EnemyLv)*15;
        MaxHP=HP;
    }
    void Update()
    {
        if(LastHP!=HP)
        {
            LastHP=HP;

            if(HP<=0)
            {
                Debug.Log("Kill");
                PublicStaticStatus.Score+=MaxHP;
                go=Instantiate(Food,gameObject.transform.position, Quaternion.identity);
                go.transform.parent=tf;
                go.GetComponent<Food>().FoodLv=Mathf.Pow(1.024f, EnemyLv)*10;
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D cld)
    {
        if(cld.gameObject.CompareTag("Player"))
        {
            Debug.Log("damage");
            GameObject.Find("HPBar").GetComponent<Slider>().value-=HP/MaxHP*0.5f;
            Destroy(gameObject);
        }
    }
}
