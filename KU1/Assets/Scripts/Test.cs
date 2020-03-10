using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int frame = 0;

    void Awake()
    {
        print("Hello Awake!");
    }
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //print("Hello WORLD!! " + frame.ToString());
        //frame++;
    }

    void OnMouseDown()
    {
        print("Mouse Down");
    }
}
