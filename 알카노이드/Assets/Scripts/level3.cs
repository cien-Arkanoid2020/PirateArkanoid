using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3 : MonoBehaviour
{
    public void level_3()
    {
        Debug.Log("level 3");
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().wall_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bg_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().ball_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bar_spawn();
        for (int i = 0; i < 7; i++)
        {
            if (i > 0)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 4);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (i == 0 || i == 7)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (i == 0 || i == 7)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
            else if (i > 2 && i < 5)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().wooden_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (i > 1 && i < 6)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 2.65f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 2.65f);
            }
        }
        for (int i = 0; i < 7; i++)
        {
            if (i > 1 && i < 6)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 2.2f);
            }
            else if (i > 0)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 2.2f);
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (i > 1)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 1.85f);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        level_3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
