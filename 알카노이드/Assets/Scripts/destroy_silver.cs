using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_silver : MonoBehaviour
{
    int silver_box_cnt = 3;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            silver_box_cnt--;
        }
        if (silver_box_cnt == 0)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<item_spawn>().item_spawn_silver(collision.transform.localPosition.x, collision.transform.localPosition.y);
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().brick_count--;
            GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score_silver();
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
