using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life_point : MonoBehaviour
{
    public int life_p=3;
    float time;
    // Start is called before the first frame update
    public void life()
    {
        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().ball_count == 0)
        {
            life_p--;
            Debug.Log(life_p);
            time = 3;
            while(time>0)
            {
                time -= Time.deltaTime;
            }
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().cannonball_spawn();
            
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
