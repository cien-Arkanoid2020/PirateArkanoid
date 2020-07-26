using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_board_clear : MonoBehaviour
{
    private Text score_text;

    // Start is called before the first frame update
    void scoreboard()
    {
        score_text.text = "score : " + GameObject.FindGameObjectWithTag("score").GetComponent<score_save>().total_score;
    }
    void Start()
    {
        score_text = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreboard();
    }
}
