using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_reset : MonoBehaviour
{
    public void resetscore()
    {
        GameObject.FindGameObjectWithTag("score").GetComponent<score_save>().total_score = 0;
    }
    public void destroyscore()
    {
        Destroy(GameObject.FindGameObjectWithTag("score"));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
