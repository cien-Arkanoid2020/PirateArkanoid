using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_manager : MonoBehaviour
{
    public int level = 1;
    public void level_1()
    {
        Debug.Log("level 1");
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().wall_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().bg_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().bar_spawn();
        for(int i=0;i<8;i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 4);
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.55f);
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 3.1f);
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().wooden_box_spawn(-2.15f + 0.6f * i, 2.65f);
        }
    }
    public void level_2()
    {
        Debug.Log("level 2");
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().bar_spawn();
        for(int i=0;i<4;i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 4);
        }
        for (int i = 0; i < 6; i++)
        {
            if(i<5)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }
        }
        for (int i = 0; i < 7; i++)
        {
            if(i<2)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
                
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().wooden_box_spawn(-2.15f + 0.6f * i, 2.65f);
        }
        for (int i = 0; i < 7; i++)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 2.2f);
        }
    }
    public void level_3()
    {
        Debug.Log("level 3");
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().wall_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().bg_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_spawn();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().bar_spawn();
        for (int i = 0; i < 7; i++)
        {
            if (i > 0)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 4);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if(i==0||i==7)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i,3.55f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }            
        }
        for (int i = 0; i < 8; i++)
        {
            if (i == 0 || i == 7)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
            else if (i > 2 && i < 5)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().wooden_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if(i>1&&i<6)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 2.65f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 2.65f);
            }
        }
        for (int i = 0; i < 7; i++)
        {
            if (i > 1 && i < 6)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 2.2f);
            }
            else if(i>0)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 2.2f);
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (i > 1)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 1.85f);
            }
        }
    }
    public void next_level(int level)
    {
        if (level == 2)
        {
            level_2();
        }
        else if (level == 3)
        {
            level_3();
        }
        else if (level == 4)
        {
            Debug.Log("All Clear!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        level_1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
