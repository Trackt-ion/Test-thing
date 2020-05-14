using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise 
{
    long seed;

    public PerlinNoise(long seed)
    { this.seed = seed; }

    public int getNoise(int x,int range) {
        int chunkSize = 8;

        int chunkIndex = x / 8;

        int prog = (x % chunkSize) / (chunkSize * 1f);

    }
        
}
