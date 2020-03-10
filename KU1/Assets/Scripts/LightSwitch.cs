using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light[] lights;

    void Awake()
    {
        lights = FindObjectsOfType<Light>();
    }

    // Start is called before the first frame update
    void Start()
    {

        foreach(var l in lights)
        {
            l.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        foreach (var l in lights)
        {
            l.enabled = !l.enabled;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //print("Trigger:"+other.gameObject.name);
    }

    void OnCollisionEnter(Collision collision)
    {
        //print("Collision:"+collision.gameObject.name);
    }
}
