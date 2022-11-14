using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameras : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;




 void Start()
    {  

         Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            CameraOne ();
        }

        if (Input.GetKeyDown("w"))
        {
            CameraTwo ();
        }

        if (Input.GetKeyDown("e"))
        {
            CameraThree ();
        }
    }

    void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
    }

    void CameraTwo()
    {
        Camera3.SetActive(false);
        Camera2.SetActive(true);
        Camera1.SetActive(false);  
    }

    void CameraThree()
    {
        Camera3.SetActive(true);
        Camera2.SetActive(false);  
        Camera1.SetActive(false);
    }
}
