using UnityEngine;
using System.Collections.Generic;

public class Terrain : MonoBehaviour
{
    public List<GameObject> block = new List<GameObject>();

    GameObject[,] grid = new GameObject[100,100];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 100; i++){
            for(int z = 0; z < 100; z++)
            {
                grid[i,z] = Instantiate(block[Random.Range(0, block.Count)], new Vector3(0,0,0), Quaternion.identity);
                grid[i,z].transform.position = grid[i,z].transform.position + new Vector3(i,Mathf.PerlinNoise(i*0.1f,z*0.1f) * 3,z);
            }            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
