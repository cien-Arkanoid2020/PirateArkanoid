using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_count--;
            if(GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_count==0)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().destroy_evr();
                Debug.Log("GAMEOVER");
            }
        }
    }
    void Win()
    {
        if(GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count==0)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().destroy_evr();
            Debug.Log("WIN");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Win();
    }
}
