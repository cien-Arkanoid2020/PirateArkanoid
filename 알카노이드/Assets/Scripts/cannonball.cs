using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bar"))
        {
            item_cannonball();
            Destroy(gameObject);
            Debug.Log("check");
            GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score_item();
        }
        else if(collision.gameObject.CompareTag("bar_long"))
        {
            item_cannonball_long();
            Destroy(gameObject);
            Debug.Log("check");
            GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score_item();
        }
        else if (collision.gameObject.CompareTag("brick"))
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>());
        }
        else if (collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
    }
    public void item_cannonball()
    {
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().cannonball_spawn();
        Debug.Log("check3");
    }
    public void item_cannonball_long()
    {
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().cannonball_spawn_long();
        Debug.Log("check3");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1.5f * Time.deltaTime, 0);
    }
}
