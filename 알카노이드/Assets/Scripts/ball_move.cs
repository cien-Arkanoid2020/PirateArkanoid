using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public float ball_spdx = 0;
    public float ball_spdy = 5;
    public Vector3 ball_spd;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.FindGameObjectWithTag("sound_manager").GetComponent<sound_manager>().crash_play();
        if (collision.gameObject.CompareTag("bar")|| collision.gameObject.CompareTag("bar_long"))
        {
            if(collision.contacts[0].normal.x!=0)
            {
                if (collision.contacts[0].normal.x < 0)
                {
                    horizontal_left();
                }
                else
                {
                    horizontal_right();
                }
            }
            else
            {
                ball_rotation((float)collision.transform.position.x - collision.contacts[0].point.x);
            }
        }
        else if (collision.gameObject.CompareTag("item")|| collision.gameObject.CompareTag("ball"))
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>());
        }
        else
        {
            if (collision.contacts[0].normal.x != 0)
            {
                if (collision.contacts[0].normal.x < 0)
                {
                    horizontal_left();
                }
                else
                {
                    horizontal_right();
                }
            }
            if (collision.contacts[0].normal.y != 0)
            {
                if(collision.contacts[0].normal.y<0)
                {
                    vertical_down();
                }
                else
                {
                    vertical_up();
                }
            }        
        }
        if(collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().ball_count--;
        }
    }
    void ballmove()
    {
        transform.Translate(ball_spdx * Time.deltaTime, ball_spdy * Time.deltaTime, 0);
    }
    public void horizontal_left()
    {
        ball_spdx = -Mathf.Abs(ball_spdx);
    }
    public void horizontal_right()
    {
        ball_spdx = Mathf.Abs(ball_spdx);
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
        ball_spdx = -5 * Mathf.Cos(Mathf.PI / 2 - l * Mathf.PI / 3);
        ball_spdy = 5 * Mathf.Sin(Mathf.PI / 2 - l * Mathf.PI / 3);
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
