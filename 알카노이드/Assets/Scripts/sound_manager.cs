using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sound_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public void ingame_bgm_play()
    {
        transform.Find("ingame").gameObject.GetComponent<AudioSource>().mute = false;
        transform.Find("ingame").gameObject.GetComponent<AudioSource>().loop = true;
    }
    public void ingame_bgm_mute()
    {
        transform.Find("ingame").gameObject.GetComponent<AudioSource>().mute = true;
        transform.Find("ingame").gameObject.GetComponent<AudioSource>().loop = false;
    }
    public void title_bgm_play()
    {
        transform.Find("title").gameObject.GetComponent<AudioSource>().mute = false;
        transform.Find("title").gameObject.GetComponent<AudioSource>().loop = true;
    }
    public void title_bgm_mute()
    {
        transform.Find("title").gameObject.GetComponent<AudioSource>().mute = true;
        transform.Find("title").gameObject.GetComponent<AudioSource>().loop = false;
    }
    public void crash_play()
    {
        transform.Find("crash").gameObject.GetComponent<AudioSource>().mute = false;
        transform.Find("crash").gameObject.GetComponent<AudioSource>().Play();
    }
    public void shoot_play()
    {
        transform.Find("shoot").gameObject.GetComponent<AudioSource>().mute = false;
        transform.Find("shoot").gameObject.GetComponent<AudioSource>().Play();
    }
    public void button_play()
    {
        transform.Find("button").gameObject.GetComponent<AudioSource>().mute = false;
        transform.Find("button").gameObject.GetComponent<AudioSource>().Play();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
