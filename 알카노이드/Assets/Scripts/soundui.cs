using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundui : MonoBehaviour
{
    public void sound_ui_active()
    {
        gameObject.SetActive(true);
    }
    public void sound_ui_inactive()
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
