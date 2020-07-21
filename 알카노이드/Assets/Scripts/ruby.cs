using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruby : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bar"))
        {
            item_ruby();
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<score_check>().score_item();
        }
        else if(collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
        
    }
    public void item_ruby()
    {
        GameObject.FindGameObjectWithTag("gameover").GetComponent<gameover>().life_count++;
        Debug.Log("check1");
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
