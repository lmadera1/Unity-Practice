using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamestart : MonoBehaviour
{

    Chunk[,,] chunks;

    // Start is called before the first frame update
    void Start()
    {
        //TODO:
        //start with one chunks for now
        //no procedural chunks yet

        int numChunks = 1;

        chunks = new Chunk[numChunks, numChunks, numChunks];

        for (int x = 0; x < numChunks; x++)
        {
            for (int y = 0; y < numChunks; y++)
            {
                for (int z = 0; z < numChunks; z++)
                {
                    chunks[x, y, z] = new Chunk(9, new Vector3(x, y, z));
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
