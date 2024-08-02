using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBasicTringle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateBasicMesh();
    }

    private void CreateBasicMesh()
    {
        // ���ο� Mesh ����
        Mesh mesh = new Mesh();

        // �ﰢ���� ���� ����
        Vector3[] vertices = new Vector3[3];
        vertices[0] = new Vector3(0, 1, 0); // ���� ����
        vertices[1] = new Vector3(-1, -1, 0); // ���� �Ʒ� ����
        vertices[2] = new Vector3(1, -1, 0); // ������ �Ʒ� ����

        // �ﰢ���� �ε��� ����
        int[] triangles = new int[3];
        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        // �ﰢ���� �׷����� ���⿡ ���� ��� �׸��� ���������� �޶�����. 

        // Mesh�� ������ �ﰢ�� ����
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        

        // Mesh�� ����ϱ� ���� GameObject ����
        GameObject triangle = new GameObject("Triangle", typeof(MeshFilter), typeof(MeshRenderer));
        triangle.GetComponent<MeshFilter>().mesh = mesh;

        // ������ ��Ƽ���� ����
        Material material = new Material(Shader.Find("Standard"));
        material.color = Color.green; // �ﰢ�� ������ �ʷϻ����� ����
        triangle.GetComponent<MeshRenderer>().material = material;

        /*
        * Material: 3D ���� ǥ�� Ư���� �����ϴ� �׷��� �Ӽ� �����Դϴ�.
        �ֿ� ���� ���: �ؽ�ó, ����, ���̴�, �ݻ���, ���� ��.
        ����Ƽ������ ��� ����: Material�� �����ϰ�, 3D ������Ʈ�� �����Ͽ� ǥ���� �ð��� �Ӽ��� �����մϴ�.
        */
    }
}
