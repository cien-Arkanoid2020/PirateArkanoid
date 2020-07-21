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
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<score_check>().score_item();
        }
        else if (collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
    }
    public void item_cannonball()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().cannonball_spawn();
        Debug.Log("check3");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * Time.deltaTime, 0);
    }
}
