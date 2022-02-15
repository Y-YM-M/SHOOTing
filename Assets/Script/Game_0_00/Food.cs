using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float FoodLv;

    [SerializeField]
    string BulletName;
    [SerializeField]
    int NumberOfBullet;
    void OnTriggerEnter2D(Collider2D cld)
    {
        if(cld.gameObject.CompareTag("Player"))
        {
            Debug.Log("eat");
            cld.gameObject.GetComponent<Player>().FoodPool.Add((BulletName,FoodLv,NumberOfBullet));
            Destroy(gameObject);
        }
    }
}
