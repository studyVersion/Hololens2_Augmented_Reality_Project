using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshControlerPiece : MonoBehaviour
{

     public MeshRenderer mainRenderer;

    void Start()
    {
        mainRenderer = GetComponent<MeshRenderer>();

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            MeshRenderer childRenderer = child.GetComponent<MeshRenderer>();

            if (childRenderer != null)
            {
                childRenderer.sharedMaterial = mainRenderer.sharedMaterial;
                childRenderer.enabled = mainRenderer.enabled;
            }
        }
    }
}
