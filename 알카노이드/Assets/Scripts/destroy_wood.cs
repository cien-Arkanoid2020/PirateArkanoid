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
