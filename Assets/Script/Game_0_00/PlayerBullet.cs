using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float ATK;
    void OnTriggerEnter2D(Collider2D cld)
    {
        if(cld.gameObject.CompareTag("Enemy"))
        {
            cld.GetComponent<Enemy>().HP-=ATK;
            Destroy(gameObject);
        }
    }
}
