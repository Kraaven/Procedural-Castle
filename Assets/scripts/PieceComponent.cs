using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PieceComponent : MonoBehaviour
{
    

    public List<GameObject> PossibleBlocks;
    public Mesh Selected;
    public Vector4 state = new Vector4(0, 0, 0, 0);

    public void Awake()
    {
        PossibleBlocks = new List<GameObject>();
    }

    public void Collapse()
    {
        GameObject Piece = Instantiate(PossibleBlocks[Random.Range(0, PossibleBlocks.Count)],transform.position, transform.rotation);
        Piece.transform.parent = gameObject.transform.parent;
        Destroy(gameObject);
        
    }
}
