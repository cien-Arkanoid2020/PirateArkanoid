﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;
    public GameObject bar;
    public GameObject bg;
    public List<GameObject> wall;
    public List<GameObject> brick;
    public float ball_spawnp;
    public float bar_spawnp;
    public float wall_spawnp;
    public float brick_spawnp;
    public int ball_count = 0;
    public int brick_count = 0;
    // Start is called before the first frame update
    public void ball_spawn()
    {
        ball = Instantiate<GameObject>(Resources.Load<GameObject>("ball"), new Vector3(0, -2.4f, 0), Quaternion.identity);
        ball_count++;
    }
    public void bar_spawn()
    {
        bar = Instantiate<GameObject>(Resources.Load<GameObject>("bar"), new Vector3(0, -2.5f, 0), Quaternion.identity);
    }
    public void wall_spawn()
    {
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_l"), new Vector3(-3, 0, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_r"), new Vector3(3, 0, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_u"), new Vector3(0, 5, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_d"), new Vector3(0, -4, 0), Quaternion.identity));
    }
    public void bg_spawn()
    {
        bg = Instantiate<GameObject>(Resources.Load<GameObject>("background"), new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void destroy_evr()
    {
        Destroy(bar);
        Destroy(ball);
        while(wall.Count!=0)
        {
            Destroy(wall[0]);
            wall.RemoveAt(0);
        }
        while(brick.Count!=0)
        {
            Destroy(brick[0]);
            brick.RemoveAt(0);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
