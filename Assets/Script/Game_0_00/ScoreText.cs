using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    Text MyText;
    float LastScore;
    void Start()
    {
        MyText=gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if(LastScore!=PublicStaticStatus.Score)
        {
            LastScore=PublicStaticStatus.Score;
            MyText.text=""+Mathf.Round(PublicStaticStatus.Score/10)*10;
        }
    }
}
