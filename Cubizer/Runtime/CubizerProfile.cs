﻿using System;

using UnityEngine;

#pragma warning disable 0169 // "field x is never used"

namespace Cubizer
{
	[Serializable]
	public class CubizerProfile : ScriptableObject
	{
		public TerrainModel terrain = new TerrainModel();
		public DbModels database = new DbModels();
		public ChunkManagerModels chunk = new ChunkManagerModels();
		public BiomeManagerModels biome = new BiomeManagerModels();
		public LiveManagerModels lives = new LiveManagerModels();
	}
}