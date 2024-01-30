using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateCastle : MonoBehaviour
{ 
    public int size;
    public float Offset;
    public int height;

    private List<PieceComponent> Blocks; 

    public GameObject testpiece;
    
    public GameObject CorridorH;
    public GameObject CorridorV;
    public GameObject CorridorWH;
    public GameObject CorridorWV;
    public GameObject LD;
    public GameObject DR;
    public GameObject RU;
    public GameObject UL;

    public PieceComponent[,] objects;
    



    public void Start()
    {
        objects = new PieceComponent[size, size];
        Blocks = new List<PieceComponent>();
        for (int i = -size; i < size; i++)
        {
            for (int j = -size; j < size; j++)
            {
                for (int k = 0; k < height; k++)
                {
                    GameObject cube = Instantiate(testpiece, new Vector3(i * Offset, k * Offset, j * Offset),
                        Quaternion.Euler(-90,0,0));
                    cube.transform.parent = gameObject.transform;
                    Blocks.Add(cube.AddComponent<PieceComponent>());
                    objects[i + size / 2, j + size / 2] = Blocks[Blocks.Count - 1];
                    
                    List<GameObject> States = Blocks[Blocks.Count - 1].PossibleBlocks;
                    
                    States.Add(CorridorH);
                    States.Add(CorridorWH);
                    States.Add(CorridorV);
                    States.Add(CorridorWV);
                    States.Add(LD);
                    States.Add(DR);
                    States.Add(RU);
                    States.Add(UL);
                    
                }
            }
        }

        int see = Blocks.Count;
        for (int i = 0; i < see; i++)
        {
            int c = Random.Range(0, Blocks.Count);
            Blocks[c].Collapse();
            Blocks.RemoveAt(c);
        
        }
        
    }
}
