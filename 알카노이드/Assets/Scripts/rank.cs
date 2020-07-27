using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rank : MonoBehaviour
{
    public GameObject gold_rank;
    public GameObject silver_rank;
    public GameObject bronze_rank;
    public GameObject wood_rank;
    public Text rank_text;
    // Start is called before the first frame update
    public void rank_system()
    {
        int score;
        score = GameObject.FindGameObjectWithTag("score").GetComponent<score_save>().total_score;
        if(score<1000)
        {
            wood_rank = Instantiate<GameObject>(Resources.Load<GameObject>("box_wood"), new Vector3(0, 0, 0), Quaternion.identity);
            wood_rank.gameObject.transform.localScale = new Vector3(1, 0.8f, 1);
            rank_text.text = "Wood";
        }
        else if(score < 2000)
        {
            wood_rank = Instantiate<GameObject>(Resources.Load<GameObject>("box_bronze"), new Vector3(0, 0, 0), Quaternion.identity);
            wood_rank.gameObject.transform.localScale = new Vector3(1, 0.8f, 1);
            rank_text.text = "Bronze";
        }
        else if (score < 3000)
        {
            wood_rank = Instantiate<GameObject>(Resources.Load<GameObject>("box_silver"), new Vector3(0, 0, 0), Quaternion.identity);
            wood_rank.gameObject.transform.localScale = new Vector3(1, 0.8f, 1);
            rank_text.text = "Silver";
        }
        else
        {
            wood_rank = Instantiate<GameObject>(Resources.Load<GameObject>("box_gold"), new Vector3(0, 0, 0), Quaternion.identity);
            wood_rank.gameObject.transform.localScale = new Vector3(1, 0.8f, 1);
            rank_text.text = "Gold";
        }
    }
    void Start()
    {
        rank_text = GameObject.Find("rank").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        rank_system();
    }
}
