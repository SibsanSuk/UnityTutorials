using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int amount = 10;
    public GameObject original;
    public List<GameObject> clones;
    void Start()
    {
        for(int i =0;i < amount; i++)
        {
            GameObject obj = Instantiate(original);
            obj.transform.position = new Vector3(0, i*0.4f, 0);
            clones.Add(obj);
        }
            
    }
}
