using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_start : MonoBehaviour
{   
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
           }

    // Update is called once per frame
    void Update()
    {   
         time += Time.deltaTime;//毎フレームの時間を加算.

        if (time >= 2f)
        {   
            Debug.Log(time);
            SceneManager.LoadScene("Game_0_00");
        }
    }
}
