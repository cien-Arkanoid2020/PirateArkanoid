using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuui : MonoBehaviour
{
    public void mainmenu_ui_active()
    {
        gameObject.SetActive(true);
    }
    public void mainmenu_ui_inactive()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
