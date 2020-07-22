using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_wood : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<item_spawn>().item_spawn_wood(collision.transform.localPosition.x, collision.transform.localPosition.y);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count--;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<score_check>().score_wood();
        }
        GameObject.FindGameObjectWithTag("gameover").GetComponent<gameover>().Win();
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
