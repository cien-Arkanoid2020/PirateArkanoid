using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_bronze : MonoBehaviour
{
    int bronze_box_cnt=2;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            bronze_box_cnt--;
        }
        if(bronze_box_cnt==0)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count--;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
