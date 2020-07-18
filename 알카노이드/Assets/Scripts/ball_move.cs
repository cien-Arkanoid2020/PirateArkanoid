﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public float ball_spdx;
    public float ball_spdy;
    public Vector3 ball_spd;

    // Start is called before the first frame update
    void ballmove()
    {
        transform.Translate(ball_spdx * Time.deltaTime, ball_spdy * Time.deltaTime, 0);
    }
    public void horizontal_rev()
    {
        ball_spdx = -ball_spdx;
    }
    public void vertical_rev()
    {
        ball_spdy = -ball_spdy;
    }
    public void ball_rotation(float l)
    {
        ball_spdx = -5 * Mathf.Cos(Mathf.PI / 2 - l * Mathf.PI/3);
        ball_spdy = 5 * Mathf.Sin(Mathf.PI / 2 - l * Mathf.PI/3);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ballmove();
    }
}
