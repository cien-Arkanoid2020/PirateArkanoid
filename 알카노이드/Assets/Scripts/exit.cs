using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void exit_in_unity()
    {
        /*if (Application.platform == RuntimePlatform.WindowsEditor)
        {
        #if UNITY_EIDTOR
             UnityEditor.EditorApplication.isPlaying = false;
        #endif
        }*/
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
