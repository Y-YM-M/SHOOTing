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

    void Start()
    {
        Debug.Log(EnemyLv);
        HP=100;//いったん
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
                go.GetComponent<Food>().FoodLv=EnemyLv;
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D cld)
    {
        if(cld.gameObject.CompareTag("Player"))
        {
            Debug.Log("p");
            GameObject.Find("HPBar").GetComponent<Slider>().value-=HP/MaxHP*0.5f;
            Destroy(gameObject);
        }
    }
}
