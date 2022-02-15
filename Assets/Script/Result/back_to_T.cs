using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class back_to_T : MonoBehaviour
{   
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
        if(Input.GetMouseButton(0)){
            audioSource.Play();
            SceneManager.LoadScene("TitleScene");
   
        }
    }
}
