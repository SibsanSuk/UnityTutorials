using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterInput : MonoBehaviour
{
    public float distancePerSecond;
    CharacterController cc;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 moveing = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        cc.Move(moveing*Time.fixedDeltaTime);
    }
}
