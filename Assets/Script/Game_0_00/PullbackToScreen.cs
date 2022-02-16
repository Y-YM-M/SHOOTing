using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullbackToScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject MyPlayer;
    Transform tf;
    Rigidbody2D rb;
    void Start()
    {
        tf=MyPlayer.transform;
        rb=MyPlayer.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tf.position.y>5.0f)
        {
            rb.AddForce( new Vector3(0,-(tf.position.y-5.0f)*Time.deltaTime*1000,0));
        }
        else if(tf.position.y<-5.0f)
        {
            rb.AddForce( new Vector3(0,-(tf.position.y+5.0f)*Time.deltaTime*1000,0));
        }
    }
}
