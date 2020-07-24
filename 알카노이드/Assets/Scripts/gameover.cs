using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public int life_count = 3;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_count==0)
            {
                Debug.Log(life_count);
                life_decrease();
            }
            if(life_count==0)
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().destroy_evr();
                Debug.Log("GAMEOVER");
            }
        }
    }
    void life_decrease()
    {
        life_count--;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().cannonball_spawn();
    }
    public void Win()
    {
        if(GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count==0)
        {
            Debug.Log("WIN");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
