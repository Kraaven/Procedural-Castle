using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCastle : MonoBehaviour
{ 
    public int size;
    public float Offset;
    public int height;
    public Mesh test;

    public GameObject testpiece;

    public void Start()
    {
        for (int i = -size; i < size; i++)
        {
            for (int j = -size; j < size; j++)
            {
                for (int k = 0; k < height; k++)
                {
                    GameObject cube = Instantiate(testpiece, new Vector3(i * Offset, k * Offset, j * Offset),
                        Quaternion.Euler(-90,0,0));
                    cube.transform.parent = gameObject.transform;
                }
            }
        }
        
        
    }
}
