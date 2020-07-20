using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    public float ball_spdx = 0;
    public float ball_spdy = 5;
    public Vector3 ball_spd;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.contacts[0].normal*5);
        if (collision.gameObject.CompareTag("bar"))
        {
            if(collision.contacts[0].normal.x!=0)
            {
                horizontal_rev();
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
                horizontal_rev();
            }
            if (collision.contacts[0].normal.y != 0)
            {
                vertical_rev();
            }        
        }
        if(collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_count--;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("check");
        GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().ball_spdy=-4;
    }
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
