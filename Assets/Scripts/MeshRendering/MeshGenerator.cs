using UnityEngine;

namespace Jozi.GameLibrary.MeshRendering
{
    [RequireComponent(typeof(MeshFilter))]
    public class MeshGenerator : MonoBehaviour
    {
        Mesh mesh;

        Vector3[] vertices;
        int[] triangles;

        private void Start()
        {
            mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;

            CreateShape();
            UpdateMesh();
        }

        private void CreateShape()
        {
            vertices = new Vector3[]
            {
            new Vector3(0,0,0),
            new Vector3(0,0,1),
            new Vector3(1,0,0),
            new Vector3(1,0,1),
            };

            triangles = new int[]
            {
            0, 1, 2,
            1, 2, 3
            };
        }

        private void UpdateMesh()
        {
            mesh.Clear();
            mesh.vertices = vertices;
            mesh.triangles = triangles;
            mesh.RecalculateNormals();
        }
    }
}