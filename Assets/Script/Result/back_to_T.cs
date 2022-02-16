using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class back_to_T : MonoBehaviour
{   
    float time = 0f;
    public AudioClip audioClip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {   

        time += Time.deltaTime;//毎フレームの時間を加算.
        if(Input.GetMouseButton(0) && time > 3f){
            audioSource.Play();
            SceneManager.LoadScene("TitleScene");
   
        }
    }
}
