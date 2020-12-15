using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; ++i)
        {
            float px = Random.Range(-7, 7);
            float py = Random.Range(-5, 5);
            Vector3 p = new Vector3(px, py, 0);
            Instantiate(prefab, p, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
