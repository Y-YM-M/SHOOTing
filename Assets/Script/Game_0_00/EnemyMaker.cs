using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> PossibleEnemy;
    float EnemyFrequency;
    float timer;
    float percentage;
    Transform tf;
    
    void Start()
    {
        tf=GameObject.Find("Advancer").transform;
        EnemyFrequency=100;
    }
    void Update()
    {
        //頻度が増える
        if(EnemyFrequency<500)
        {
            EnemyFrequency+=Time.deltaTime*2.0f;
        }
        else if (EnemyFrequency>500)
        {
            EnemyFrequency=500;
        }

        //頻度の判定式
        timer+=Time.deltaTime;
        if(timer>=0.2f)
        {
            timer-=0.2f;

            percentage+=Time.deltaTime*EnemyFrequency;
            if(Random.value<=percentage/100)
            {
                percentage=0;

                MakeMonster();
            }
        }
    }
    void MakeMonster()
    {
        GameObject go=Instantiate(PossibleEnemy[Random.Range(0,PossibleEnemy.Count)],new Vector3(8,Random.Range(0.0f,9.0f)-4.5f,0), Quaternion.identity);
        go.transform.parent=tf;
        go.GetComponent<Enemy>().EnemyLv=Time.time*Random.Range(0.8f,1.0f);
    }
}
