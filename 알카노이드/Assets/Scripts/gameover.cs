using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public List<GameObject> flag;
    public int life_count = 3;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            if (GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().ball_count==0)
            {
                Debug.Log(life_count);
                life_decrease();
            }
            if(life_count==0)
            {
                GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().destroy_evr();
                GameObject.FindGameObjectWithTag("score").GetComponent<score_save>().if_die();
                Debug.Log("GAMEOVER");
                SceneManager.LoadScene("End");
            }
        }
    }
    void life_decrease()
    {
        life_count--;
        life_destroy(life_count);
        Destroy(GameObject.Find("bar_long"));
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().destroy_bar();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bar_spawn();
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().cannonball_spawn();
    }
    public void Win()
    {
        if(GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().brick_count==0)
        {
            Debug.Log("WIN");
            GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().destroy_evr();
            Time.timeScale = 0.0f;
        }
    }
    public void life_add(int lp)
    {
        flag.Add(Instantiate<GameObject>(Resources.Load<GameObject>("life"), new Vector3(3.1f - lp * 0.6f, 4.7f, -2), Quaternion.identity));
    }
    public void life_destroy(int lp)
    {
        Destroy(flag[lp]);
        flag.RemoveAt(lp);
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
