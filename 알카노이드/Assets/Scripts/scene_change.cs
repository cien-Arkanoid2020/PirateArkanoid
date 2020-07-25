using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change : MonoBehaviour
{
    public void ChangeStartScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Start");
    }
    public void ChangeLevel1Scene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level1");
    }
    public void ChangeLevel2Scene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level2");
    }
    public void ChangeLevel3Scene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level3");
    }
    public void ChangeEndScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("End");
    }
    public void ChangePauseScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Pause");
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
