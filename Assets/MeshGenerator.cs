using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    protected Mesh mesh; 

    protected Vector3[] vertices;
    int[] triangles;

    public int xSize = 20;
    public int zSize = 20;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        //StartCoroutine(CreateShape());
        CreateShape();

    }

    private void Update()
    {
        UpdateMesh();
    }

     void CreateShape()
    {
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];
        
        for (int i = 0, z = 0; z <= zSize; z++)
        {
            
            for (int x = 0; x <= xSize; x++, i++)
            {
                float y = Mathf.PerlinNoise(x * 0.3f, z * 0.3f) * 2f;
                vertices[i] = new Vector3(x, y, z);

            }




        }

        /*
        vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 0, 1),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 1)
        };
        

        int vert = 0;
        int tris = 0;
        triangles = new int[6*xSize*zSize];

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {

                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = xSize + 1 + vert;
                triangles[tris + 2] = 1 + vert;
                triangles[tris + 3] = 1 + vert;
                triangles[tris + 4] = xSize + 1 + vert;
                triangles[tris + 5] = xSize + 2 + vert;

                vert++;
                tris += 6;

               // yield return new WaitForSeconds(0.1f);
            }
            vert++;
        }

    }

    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }


    private void OnDrawGizmos()
    {
        if (vertices == null)
        {
            return;
        }
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], .1f);
        }
    }


   
} */

