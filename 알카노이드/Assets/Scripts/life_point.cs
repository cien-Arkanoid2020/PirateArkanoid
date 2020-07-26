using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life_point : MonoBehaviour
{
    public List<GameObject> flag;
    public int life_p=3;
    float time;
    // Start is called before the first frame update
    public void life()
    {
        if (GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().ball_count == 0)
        {
            life_p--;
            Debug.Log(life_p);
            life_destroy(life_p);
            time = 3;
            while(time>0)
            {
                time -= Time.deltaTime;
            }
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().cannonball_spawn();
            
        }
    }
    public void life_add(int lp)
    {
        flag.Add(Instantiate<GameObject>(Resources.Load<GameObject>("life"), new Vector3(3.1f - lp * 0.6f, 4.7f, -2), Quaternion.identity));
    }
    public void life_destroy(int lp)
    {
        Destroy(flag[lp - 1]);
        flag.RemoveAt(lp-1);
    }
    void Start()
    {
        life_add(1);
        life_add(2);
        life_add(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
