using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPieces : MonoBehaviour
{
    public Transform SpawnTarget;
    public GameObject FirstPiece;
    public GameObject piece;
    
    private Vector3 initialPosition;
    private bool hasChangedPosition;

    private void Start()
    {
        initialPosition = FirstPiece.transform.position;
        hasChangedPosition = false;
    }

    private void Update()
    {   
    
        if (!hasChangedPosition && FirstPiece.transform.position != initialPosition)
        {
            var newPiece = Instantiate(piece, SpawnTarget.position, SpawnTarget.rotation);
            // Additional logic or modifications for the new piece if necessary
            FirstPiece = newPiece;
            hasChangedPosition = true;
        }else {
             hasChangedPosition = false;
        }
    }
}
