using UnityEngine;
using System.Collections.Generic;

public class MeshGenerator : MonoBehaviour
{
    MeshFilter thisMeshFilter;
    public EventExample eventController;

    private void Start()
    {
        eventController.basicEvent.AddListener(MeshGen);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void MeshGen()
    {
        thisMeshFilter = this.gameObject.GetComponent<MeshFilter>();

        Mesh newMesh = new Mesh();

        List<Vector3> verticies = new List<Vector3>();

        verticies.Add(new Vector3(0, 1, 0));
        verticies.Add(new Vector3(0, 0, 0));
        verticies.Add(new Vector3(1, 0, 0));
        verticies.Add(new Vector3(1, 1, 0));

        newMesh.SetVertices(verticies);

        List<int> triangles = new List<int>();
        triangles.Add(0);
        triangles.Add(2);
        triangles.Add(1);
        triangles.Add(0);
        triangles.Add(3);
        triangles.Add(2);

        newMesh.SetTriangles(triangles,0);

        newMesh.RecalculateNormals();
        newMesh.RecalculateBounds();

        thisMeshFilter.sharedMesh = newMesh;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
