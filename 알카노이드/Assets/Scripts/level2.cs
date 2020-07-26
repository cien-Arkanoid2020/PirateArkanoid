using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{
    public void level_2()
    {
        Debug.Log("level 2");
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().wall_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bg_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().ball_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bar_spawn();
        for (int i = 0; i < 4; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 4);
        }
        for (int i = 0; i < 6; i++)
        {
            if (i < 5)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 3.55f);
            }
        }
        for (int i = 0; i < 7; i++)
        {
            if (i < 2)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }
            else
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 3.1f);
            }

        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().wooden_box_spawn(-2.15f + 0.6f * i, 2.65f);
        }
        for (int i = 0; i < 7; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 2.2f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        level_2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
