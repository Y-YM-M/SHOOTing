using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_sc : MonoBehaviour
{   
    Text MyText;
    float score;
    // Start is called before the first frame update
    void Start()
    {   
        MyText=gameObject.GetComponent<Text>();
        score = PublicStaticStatus.Score;

    }

    // Update is called once per frame
    void Update()
    {
        MyText.text=""+Mathf.Round(score/10)*10;
        

    }
}
