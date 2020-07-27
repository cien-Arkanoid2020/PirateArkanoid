using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject bar;
    public GameObject bar_long;
    public GameObject bg;
    public List<GameObject> ball;
    public List<GameObject> wall;
    public List<GameObject> brick;
    public float ball_spawnp;
    public float bar_spawnp;
    public float wall_spawnp;
    public float brick_spawnp;
    public int ball_count = 0;
    public int brick_count = 0;
    // Start is called before the first frame update
    public void ball_spawn()
    {
        GameObject.FindGameObjectWithTag("sound_manager").GetComponent<sound_manager>().shoot_play();
        ball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ball"), new Vector3(0, -2.4f, 0), Quaternion.identity));
        ball_count++;
    }
    public void cannonball_spawn()
    {
        GameObject.FindGameObjectWithTag("sound_manager").GetComponent<sound_manager>().shoot_play();
        ball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ball"), new Vector3(bar.transform.localPosition.x, -3.4f, 0), Quaternion.identity));
        ball_count++;
    }
    public void cannonball_spawn_long()
    {
        GameObject.FindGameObjectWithTag("sound_manager").GetComponent<sound_manager>().shoot_play();
        ball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ball"), new Vector3(bar_long.transform.localPosition.x, -3.4f, 0), Quaternion.identity));
        ball_count++;
    }
    public void bar_spawn()
    {
        bar = Instantiate<GameObject>(Resources.Load<GameObject>("bar"), new Vector3(0, -3.5f, 0), Quaternion.identity);
    }
    public void bar_spawn_long()
    {
        bar_long = Instantiate<GameObject>(Resources.Load<GameObject>("bar_long"), new Vector3(bar.transform.localPosition.x, -3.5f, 0), Quaternion.identity);
        Destroy(bar);
    }
    public void wall_spawn()
    {
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_l"), new Vector3(-3.3f, 0, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_r"), new Vector3(3.3f, 0, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_u"), new Vector3(0, 5, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_d"), new Vector3(0, -5, 0), Quaternion.identity));
    }
    public void bg_spawn()
    {
        bg = Instantiate<GameObject>(Resources.Load<GameObject>("background"), new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void destroy_bar()
    {
        Destroy(bar);
        Destroy(bar_long);
    }
    public void destroy_evr()
    {
        Destroy(bar);
        Destroy(bar_long);
        while (ball.Count != 0)
        {
            Destroy(ball[0]);
            ball.RemoveAt(0);
            ball_count--;
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
