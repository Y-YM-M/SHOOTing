using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscActivatorStarter : MonoBehaviour
{
    
    [SerializeField]
    private GameObject go;
    void Start()
    {
        if(!GameObject.Find("EscActivator"))
        {
            go=Instantiate(go);
            go.name="EscActivator";
        }
    }
}
