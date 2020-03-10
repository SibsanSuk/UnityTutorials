using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lamp : MonoBehaviour
{
    public UnityEvent onMouseDown;
    public Light[] lights;
    public bool lightOn = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var l in lights)
        {
            l.gameObject.SetActive(lightOn);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        lightOn = !lightOn;
        foreach (var l in lights)
        {
            l.gameObject.SetActive(lightOn);
        }
        
    }
}
