﻿using UnityEngine;

namespace Cubizer
{
	public struct TerrainMesh
	{
		public Vector3[] vertices;
		public Vector3[] normals;
		public Vector2[] uv;
		public int[] indices;

		public TerrainMesh(int verticesCount, int indicesCount)
		{
			vertices = new Vector3[verticesCount];
			normals = new Vector3[verticesCount];
			uv = new Vector2[verticesCount];
			indices = new int[indicesCount];
		}
	}
}