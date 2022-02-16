using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private GameObject MyBackground;
    bool MadeBackground=false;
    void Update()
    {
        transform.Translate(new Vector3(Time.deltaTime*0.8f,0,0));
        if(transform.position.x<=0&&!MadeBackground)
        {
            GameObject go=Instantiate(MyBackground,transform.position+new Vector3(28.3f,0,0),Quaternion.identity);
            go.transform.parent=GameObject.Find("Advancer").transform;
            MadeBackground=true;
        }
    }
}
