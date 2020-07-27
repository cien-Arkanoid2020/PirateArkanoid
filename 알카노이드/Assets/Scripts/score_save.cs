using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_save : MonoBehaviour
{
    public int total_score=0;
    public void savescore()
    {
        if(GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().brick_count==0)
        {
            total_score = total_score + GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score;
        }
    }
    public void if_die()
    {
        total_score = total_score + GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score;
    }
    // Start is called before the first frame update
    void Start()
    {
        total_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        savescore();
    }
}
