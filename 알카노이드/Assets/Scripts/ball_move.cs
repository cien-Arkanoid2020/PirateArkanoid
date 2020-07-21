using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public float ball_spdx=0;
    public float ball_spdy=5;
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
    public void vertical_down()
    {
        ball_spdy = -Mathf.Abs(ball_spdy);
    }
    public void vertical_up()
    {
        ball_spdy = Mathf.Abs(ball_spdy);
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
