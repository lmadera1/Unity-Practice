using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Chunk
{

    Dictionary<Vector3, Voxel> voxels;
    Vector3 chunkPosition;

    public Chunk(int chunkSize, Vector3 chunkPosition)
    {
        this.chunkPosition = chunkPosition;

        this.voxels = new Dictionary<Vector3, Voxel>();
        for (int x = 0; x < chunkSize; x++)
        {
            for (int y = 0; y < chunkSize; y++)
            {
                for (int z = 0; z < chunkSize; z++)
                {
                    Vector3 key = new Vector3(x, y, z);
                    Color color = new Color(90, 0, 0);
                    Voxel vox = new Voxel(key, color);
                    this.voxels.Add(key, vox);
                }
            }
        }
    }
}
