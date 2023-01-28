using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text score;

    bool gameRunning;

    float nextTime;

    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        gameRunning = true;
        nextTime = Time.time + interval;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunning && Time.time >= nextTime)
        {
            score.text = (int.Parse(score.text) + 1).ToString();
            nextTime = Time.time + interval;
        }
    }

    public void StopScoring()
    {
        gameRunning = false;
    }
}
