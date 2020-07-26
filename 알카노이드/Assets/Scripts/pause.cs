using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public void pause_game()
    {
        Time.timeScale = 0.0f;
        gameObject.SetActive(true);
    }
    public void pause_ui_active()
    {
        gameObject.SetActive(true);
    }
    public void pause_ui_inactive()
    {
        gameObject.SetActive(false);
    }
    public void resume_game()
    {
        Time.timeScale = 1.0f;
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
