using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleController : MonoBehaviour
{
    public GameObject scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = GameObject.Find("Counter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        ScoreCounter counter = scoreCounter.GetComponent<ScoreCounter>();
        counter.CountUp();
        Destroy(gameObject);
    }
}
