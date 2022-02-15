using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advancer : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(-Time.deltaTime*3,0,0));
    }
}
