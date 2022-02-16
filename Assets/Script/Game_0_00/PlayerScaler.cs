using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    GameObject MyPlayer;
    float LastScore;
    void Start()
    {
        MyPlayer=GameObject.Find("Player");
    }

    void Update()
    {
        if(LastScore!=PublicStaticStatus.Score)
        {
            LastScore=PublicStaticStatus.Score;
            MyPlayer.transform.localScale=Vector3.one*((Mathf.Pow(PublicStaticStatus.Score,0.2f)+0.2f)/1.2f);
            gameObject.transform.position=new Vector3((((Mathf.Pow(PublicStaticStatus.Score,0.2f)+0.2f)/1.2f)-1)/2,0,0);
        }
    }
}
