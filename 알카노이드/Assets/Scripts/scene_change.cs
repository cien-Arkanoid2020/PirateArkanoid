using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change : MonoBehaviour
{
    public void ChangeStartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void ChangeLevel1Scene()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ChangeLevel2Scene()
    {
        SceneManager.LoadScene("Level2");
    }
    public void ChangeLevel3Scene()
    {
        SceneManager.LoadScene("Level3");
    }
    public void ChangeEndScene()
    {
        SceneManager.LoadScene("End");
    }
    public void ChangePauseScene()
    {
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
