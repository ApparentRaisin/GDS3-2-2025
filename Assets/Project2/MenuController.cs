using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public KeyCode pauseKey;
    public bool startEnabled, quitEnabled;
    public static bool gamePaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            gamePaused = !gamePaused;
        }
    }
}
