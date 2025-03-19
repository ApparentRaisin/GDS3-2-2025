using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EventExample : MonoBehaviour
{
    public Weapon myCoolItem;
    public UnityEvent basicEvent = new UnityEvent();
    bool keyPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basicEvent.AddListener(delegate { 
            Debug.Log("working but I am a delegate now!");
            CheckIfWorking();
        });
        StartCoroutine(waitForSomething());
    }

    void CheckIfWorking()
    {
        Debug.Log("Yes this is working!");
    }

    IEnumerator waitForSomething()
    {
        Debug.Log("Start");
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Escape) == true);
        Debug.Log("End");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            basicEvent.Invoke();
            keyPressed = true;
        }
    }
}

