using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public void level_1()
    {
        Debug.Log("level 1");
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().wall_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bg_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().ball_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bar_spawn();
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().gold_box_spawn(-2.15f + 0.6f * i, 4);
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().silver_box_spawn(-2.15f + 0.6f * i, 3.55f);
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().bronze_box_spawn(-2.15f + 0.6f * i, 3.1f);
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<brick_spawn>().wooden_box_spawn(-2.15f + 0.6f * i, 2.65f);
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
