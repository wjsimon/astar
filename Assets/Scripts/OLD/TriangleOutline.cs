﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriangleOutline : MonoBehaviour {

	public AmericaFuckYeah info;

	private Vector3 start;
	private Vector3 end;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		end = Input.mousePosition;
		if (Input.GetKeyDown(KeyCode.Space))
			start = new Vector3(end.x / Screen.width, end.y / Screen.height, 0);
	}

    /*
	void OnPostRender()
	{
		List<Segment> tris = info.triangles;

		Material mat = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		GL.PushMatrix();
		mat.SetPass(0);
		GL.LoadOrtho();
		GL.Begin(GL.LINES);
		GL.Color(Color.red);

		/*
		foreach (Segment t in tris) {
			for (int i = 0; i < t.Count; i++) {
				GL.Vertex(t.verticies [i]);
				GL.Vertex(t.verticies [i + 1]);
				//triangle.verticies [i], triangle.verticies [i + 1]
			}
		}

		GL.Vertex(start);
		GL.Vertex(new Vector3(end.x / Screen.width, end.y / Screen.height, 0));
		GL.End();
		GL.PopMatrix();
	} 	
*/	
}
