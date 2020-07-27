using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sapphire : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bar"))
        {
            item_sapphire();
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score_item();
        }
        else if(collision.gameObject.CompareTag("bar_long"))
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("score_manager").GetComponent<score_check>().score_item();
        }
        else if (collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("brick"))
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>());
        }
    }
    public void item_sapphire()
    {
        //GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bar.transform.localScale += new Vector3(0.2f, 0.0f, 0.0f);
        GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().bar_spawn_long();
        Debug.Log("check2");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1.5f * Time.deltaTime, 0);
    }
}
