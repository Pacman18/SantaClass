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
        // 새로운 Mesh 생성
        Mesh mesh = new Mesh();

        // 삼각형의 정점 설정
        Vector3[] vertices = new Vector3[3];
        vertices[0] = new Vector3(0, 1, 0); // 위쪽 정점
        vertices[1] = new Vector3(-1, -1, 0); // 왼쪽 아래 정점
        vertices[2] = new Vector3(1, -1, 0); // 오른쪽 아래 정점

        // 삼각형의 인덱스 설정
        int[] triangles = new int[3];
        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        // 삼각형이 그려지는 방향에 따라 어떻게 그림이 보여질지가 달라진다. 

        // Mesh에 정점과 삼각형 설정
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        

        // Mesh를 사용하기 위한 GameObject 생성
        GameObject triangle = new GameObject("Triangle", typeof(MeshFilter), typeof(MeshRenderer));
        triangle.GetComponent<MeshFilter>().mesh = mesh;

        // 간단한 머티리얼 설정
        Material material = new Material(Shader.Find("Standard"));
        material.color = Color.green; // 삼각형 색상을 초록색으로 설정
        triangle.GetComponent<MeshRenderer>().material = material;

        /*
        * Material: 3D 모델의 표면 특성을 정의하는 그래픽 속성 집합입니다.
        주요 구성 요소: 텍스처, 색상, 셰이더, 반사율, 광택 등.
        유니티에서의 사용 예제: Material을 생성하고, 3D 오브젝트에 적용하여 표면의 시각적 속성을 변경합니다.
        */
    }
}
