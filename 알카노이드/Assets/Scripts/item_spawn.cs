using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_spawn : MonoBehaviour
{
    public float percentage;
    public List<GameObject> item_ruby;
    public List<GameObject> item_sapphire;
    public List<GameObject> item_cannonball;
    // Start is called before the first frame update
    public void item_spawn_wood(float x,float y)
    {
        int spawn_percentage;
        float select_item;
        spawn_percentage = Random.Range(0, 100);
        if (spawn_percentage<5)
        {
            Debug.Log("w o");
            select_item = Random.Range(0, 100);
            if (select_item <25)
            {
                item_ruby.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ruby"), new Vector3(x,y,0), Quaternion.identity));
                Debug.Log("r");
            }
            else if (select_item < 50)
            {
                item_sapphire.Add(Instantiate<GameObject>(Resources.Load<GameObject>("sapphire"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("s");
            }
            else
            {
                item_cannonball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("cannonball"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("c");
            }
        }
        else
            Debug.Log("w x");
    }
    public void item_spawn_bronze(float x, float y)
    {
        int spawn_percentage;
        float select_item;
        spawn_percentage = Random.Range(0, 100);
        if (spawn_percentage < 20)
        {
            Debug.Log("b o");
            select_item = Random.Range(0, 100);
            if (select_item < 25)
            {
                item_ruby.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ruby"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("r");
            }
            else if (select_item < 50)
            {
                item_sapphire.Add(Instantiate<GameObject>(Resources.Load<GameObject>("sapphire"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("s");
            }
            else
            {
                item_cannonball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("cannonball"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("c");
            }
        }
        else
            Debug.Log("b x");
    }
    public void item_spawn_silver(float x, float y)
    {
        int spawn_percentage;
        float select_item;
        spawn_percentage = Random.Range(0, 100);
        if (spawn_percentage < 30)
        {
            Debug.Log("s o");
            select_item = Random.Range(0, 100);
            if (select_item < 25)
            {
                item_ruby.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ruby"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("r");
            }
            else if (select_item < 50)
            {
                item_sapphire.Add(Instantiate<GameObject>(Resources.Load<GameObject>("sapphire"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("s");
            }
            else
            {
                item_cannonball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("cannonball"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("c");
            }
        }
        else
            Debug.Log("s x");
    }
    public void item_spawn_gold(float x, float y)
    {
        int spawn_percentage;
        float select_item;
        spawn_percentage = Random.Range(0, 100);
        if (spawn_percentage < 50)
        {
            Debug.Log("g o");
            select_item = Random.Range(0, 100);
            if (select_item < 25)
            {
                item_ruby.Add(Instantiate<GameObject>(Resources.Load<GameObject>("ruby"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("r");
            }
            else if (select_item < 50)
            {
                item_sapphire.Add(Instantiate<GameObject>(Resources.Load<GameObject>("sapphire"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("s");
            }
            else
            {
                item_cannonball.Add(Instantiate<GameObject>(Resources.Load<GameObject>("cannonball"), new Vector3(x, y, 0), Quaternion.identity));
                Debug.Log("c");
            }
        }
        else
            Debug.Log("g x");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
