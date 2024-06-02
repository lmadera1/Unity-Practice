using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Voxel
{
    public Vector3 position;
    public Color color;
    

    public Voxel(Vector3 position, Color color)
    {
        this.position = position;
        this.color = color;
    }
}
