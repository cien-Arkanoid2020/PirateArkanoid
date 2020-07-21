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
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<score_check>().score_item();
        }
        else if (collision.gameObject.CompareTag("gameover"))
        {
            Destroy(gameObject);
        }
    }
    public void item_sapphire()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().bar.transform.localScale += new Vector3(0.2f, 0.0f, 0.0f);
        Debug.Log("check2");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * Time.deltaTime, 0);
    }
}
