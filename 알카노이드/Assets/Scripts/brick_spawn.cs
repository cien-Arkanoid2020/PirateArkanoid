using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick_spawn : MonoBehaviour
{
    public List<GameObject> wood;
    public List<GameObject> bronze;
    public List<GameObject> silver;
    public List<GameObject> gold;
    // Start is called before the first frame update
    public void wooden_box_spawn(float x, float y)
    {
        wood.Add(Instantiate<GameObject>(Resources.Load<GameObject>("box_wood"), new Vector3(x, y, 0), Quaternion.identity));
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count++;
    }
    public void bronze_box_spawn(float x, float y)
    {
        bronze.Add(Instantiate<GameObject>(Resources.Load<GameObject>("box_bronze"), new Vector3(x, y, 0), Quaternion.identity));
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count++;
    }
    public void silver_box_spawn(float x, float y)
    {
        silver.Add(Instantiate<GameObject>(Resources.Load<GameObject>("box_silver"), new Vector3(x, y, 0), Quaternion.identity));
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count++;
    }
    public void gold_box_spawn(float x, float y)
    {
        gold.Add(Instantiate<GameObject>(Resources.Load<GameObject>("box_gold"), new Vector3(x, y, 0), Quaternion.identity));
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Spawn>().brick_count++;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
