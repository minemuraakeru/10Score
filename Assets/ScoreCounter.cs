using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CountUp()
    {
        score = score + 1;
        GetComponent<Text>().text = score.ToString();
    }
}
