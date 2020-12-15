using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed.y += -9.8f * Time.deltaTime;
        transform.position = transform.position + Time.deltaTime * speed;
    }
}
