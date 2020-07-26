using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_check : MonoBehaviour
{
    public int score=0;
    // Start is called before the first frame update
    public void score_item()
    {
        score += 100;
    }
    public void score_wood()
    {
        score += 100;
    }
    public void score_bronze()
    {
        score += 300;
    }
    public void score_silver()
    {
        score += 500;
    }
    public void score_gold()
    {
        score += 1000;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
