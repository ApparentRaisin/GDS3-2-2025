using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuController.gamePaused == true)
        {
            return;
        }
        
        Debug.Log("Playing!");
        
    }
}
