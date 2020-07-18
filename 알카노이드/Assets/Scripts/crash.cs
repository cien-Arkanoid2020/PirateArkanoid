using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.contacts[0].normal*5);
        if (collision.gameObject.CompareTag("bar"))
        {
            if(collision.contacts[0].normal.x!=0)
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().horizontal_rev();
            }
            else
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().ball_rotation((float)collision.transform.position.x - collision.contacts[0].point.x);
            }
        }
        else
        {
            if (collision.contacts[0].normal.x != 0)
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().horizontal_rev();
            }
            if (collision.contacts[0].normal.y != 0)
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().vertical_rev();
            }        
        }
        if(collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("check");
        GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().ball_spdy=-4;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
