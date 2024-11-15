using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CreateMesh : MonoBehaviour
{
    public Material material;
 
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        MeshRenderer mr = GetComponent<MeshRenderer>();
 
        Vector3[] verts = new Vector3[4];
        int[] trinangles = { 0, 1, 3, 1, 2, 3 };
 
        verts[0] = new Vector3(-5, 5, 5);
        verts[1] = new Vector3(5, 5, 5);
        verts[2] = new Vector3(10, -5, 5);
        verts[3] = new Vector3(-10, -5, 5);
 
        Mesh mesh = new Mesh();
        mesh.vertices = verts;
        mesh.triangles = trinangles;
        mesh.RecalculateNormals();
 
        mf.sharedMesh = mesh;
        mr.sharedMaterial = material;
    }
}
