using UnityEngine;

public class NonplayerCharacter : MonoBehaviour
{
    public string name;
    public string description;
    public Texture2D portrait;

    public Vector3[] route;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        

        for(int i = 0; i < route.Length; i++)
        {
            Gizmos.DrawSphere(route[i], 1f);
            Gizmos.DrawLine(route[i], route[(i + 1) % route.Length]);
        }
    }
}
