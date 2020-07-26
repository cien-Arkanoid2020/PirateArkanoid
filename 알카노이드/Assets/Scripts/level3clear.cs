using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("spawn_manager").GetComponent<Spawn>().brick_count == 0)
        {
            Debug.Log("WIN");
            SceneManager.LoadScene("GameClear");
        }
    }
}
