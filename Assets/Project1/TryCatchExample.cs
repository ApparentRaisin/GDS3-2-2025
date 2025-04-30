using UnityEngine;
using System;

public class TryCatchExample : MonoBehaviour
{
    public GameObject tempObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            Instantiate(tempObject);
        }
        catch(Exception e)
        {
            Debug.Log("error, please add a object");
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
        
        Debug.Log("Spawned");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
