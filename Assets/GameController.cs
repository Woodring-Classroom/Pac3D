using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    private int score;
    private TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreLabel").GetComponent<TMP_Text>();  
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Random.Range(-1000, 1000);
    }
}
