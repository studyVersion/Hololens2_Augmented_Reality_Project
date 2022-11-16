using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lucesMaquina : MonoBehaviour
{
    public GameObject luzInterior;
    public GameObject luzExterior;
    
    public GameObject bombillaInterior;
    public GameObject bombillaExterior;

    public Renderer rendererInterior;
    public Renderer rendererExterior;

    public Color luzAmarilla;
    public Color luzRoja;

    void Start()
    {
        rendererInterior = bombillaInterior.GetComponent<Renderer>();
        rendererExterior = bombillaExterior.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (luzInterior.activeSelf) {
           rendererInterior.material.SetColor("_Color",  luzAmarilla);
        } else {
           rendererInterior.material.SetColor("_Color",  Color.white);
        }
        
        if (luzExterior.activeSelf) {
           rendererExterior.material.SetColor("_Color",  luzRoja);
        } else {
           rendererExterior.material.SetColor("_Color",  Color.white);
        }
    }
}
