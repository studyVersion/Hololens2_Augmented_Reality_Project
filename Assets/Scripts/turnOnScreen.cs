using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnScreen : MonoBehaviour
{
    public Canvas canvas;
    private bool turned;
  

    void Start()
    {
        canvas.enabled = false;
    }
    

    public void turnOn()
    {
        if(!turned){
            turned = true;
        }
    }

    public void turnOff()
    {
        if(turned){
            turned = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (turned){

            canvas.enabled = true;

        }else{
            canvas.enabled = false;
        }
    }
}
