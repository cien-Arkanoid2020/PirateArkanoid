using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearui : MonoBehaviour
{
    public void clear_ui_active()
    {
        gameObject.SetActive(true);
    }
    public void clear_ui_inactive()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
