using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SetMesh : MonoBehaviour {
	public MeshFilter mf = null;
	public MeshRenderer mr = null;

	public Vector3 point = Vector3.up; 
	public int numberOfPoints = 10; 

	private Mesh mesh; 
	private Vector3[] vertices; 
	private int[] triangles;
	// Use this for initialization
	void Start () {
		mf = gameObject.GetComponent<MeshFilter>();
		mr = gameObject.GetComponent<MeshRenderer>();
//		Vector2[] uvs = new Vector2[8];
//		uvs [0] = new Vector2( 0,0);//(0,0)
//		uvs [1] = new Vector2(1f,0);//(1,0)
//		uvs [2] = new Vector2(0f,1);//(0,1)
//		uvs [3] = new Vector2(1f,1);//(1,1)
//		uvs [4] = new Vector2( 0,0);//(0,0)
//		uvs [5] = new Vector2(1f,0);//(1,0)
//		uvs [6] = new Vector2(0f,1);//(0,1)
//		uvs [7] = new Vector2(1f,1);//(1,1)
//		Vector3[] vertices = new Vector3[8];
//		vertices [0] = new Vector3( 0f,0f,1f); //(0,0)
//		vertices [1] = new Vector3(0.5f,0f,1f);   //(1,0)
//		vertices [2] = new Vector3(0f,0.5f,1f);//(0,1)
//		vertices [3] = new Vector3(0.5f,0.5f,1f); //(1,1)
//		vertices [4] = new Vector3(0.5f,0,0); //(0,0)
//		vertices [5] = Vector3.up;   //(1,0)
//		vertices [6] = new Vector3(0.5f,1,0);//(0,1)
//		vertices [7] = Vector3.one; //(1,1)
//		float a=0.5f,b=0.5f;
//		vertices [4] = new Vector3(a+0f,b+0f,1f); //(0,0)
//		vertices [5] = new Vector3(a+0.5f,b+0f,1f);   //(1,0)
//		vertices [6] = new Vector3(a+0f,b+0.5f,1f);//(0,1)
//		vertices [7] = new Vector3(a+0.5f,b+0.5f,1f); //(1,1)
//		int[] triangles = new int[12]{0,2,1,1,2,3,4,6,5,5,6,7};
//		mf.mesh = new Mesh ();
//		mf.mesh.vertices = vertices;
//		mf.mesh.triangles = triangles; 
//		mf.mesh.uv = uvs;
		int width = 8;
		int height = 5;
		float wf = 1.0f / width;
		float hf = 1.0f / height;
		Vector3[] vertices = new Vector3[width*height*4];
		Vector2[] uvs = new Vector2[width*height*4];
		int[] triangles = new int[width*height*6];
		for (int h = 0; h < height; ++h) {
			for (int w = 0; w < width; ++w) {
				int num = h * width + w;
				int count = num * 4;
				int tri_count = num * 6;
				float a=w*wf,b=h*hf;
				vertices [count] = new Vector3(a+0f,b+0f,1f); //(0,0)
				vertices [count+1] = new Vector3(a+wf,b+0f,1f);   //(1,0)
				vertices [count+2] = new Vector3(a+0f,b+hf,1f);//(0,1)
				vertices [count+3] = new Vector3(a+wf,b+hf,1f); //(1,1)
				uvs [count] = new Vector2( 0,0);
				uvs [count+1] = new Vector2(1f,0);
				uvs [count+2] = new Vector2(0f,1);
				uvs [count+3] = new Vector2(1f,1);

				//{0,2,1,1,2,3,4,6,5,5,6,7}
				triangles[tri_count] = count;
				triangles[tri_count+1] = count+2;
				triangles[tri_count+2] = count+1;
				triangles[tri_count+3] = count+1;
				triangles[tri_count+4] = count+2;
				triangles[tri_count+5] = count+3;

			}
		}

		mf.mesh = new Mesh ();
		mf.mesh.vertices = vertices;
		mf.mesh.triangles = triangles; 
		mf.mesh.uv = uvs;
//		GetComponent<MeshFilter>().mesh = mesh = new Mesh(); 
//		mesh.name = "Star Mesh"; 
//
//		vertices = new Vector3[numberOfPoints + 1]; 
//		triangles = new int[numberOfPoints * 3]; 
//		float angle = -360f / numberOfPoints; 
//		for(int v = 1, t = 1; v < vertices.Length; v++, t += 3){ 
//			vertices[v] = Quaternion.Euler(0f, 0f, angle * (v - 1)) * point; 
//			triangles[t] = v; 
//			triangles[t + 1] = v + 1; 
//		} 
//		triangles[triangles.Length - 1] = 1; 
//		mesh.vertices = vertices; 
//		mesh.triangles = triangles; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
