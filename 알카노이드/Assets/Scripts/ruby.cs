using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruby : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bar"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<item_spawn>().ruby();
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<score_check>().score_item();
        }
        else if(collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
        
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
