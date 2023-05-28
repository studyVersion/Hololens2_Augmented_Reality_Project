using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRender : MonoBehaviour
{
   
    public GameObject otherCollider;
    bool value = false;

    void start(){
        value = false;
    }
     public void change(){
        value = true;
    }

    // Update is called once per frame
       private void OnTriggerEnter(Collider other)
    {
        // Check if the other object is the clap target
        if (value)
        {
  
                
                    DisableChildRenderers();
                    MeshRenderer renderer1 = transform.GetChild(0).GetComponent<MeshRenderer>();
                    renderer1.enabled = true;
                    
           
    
        }
    }

      private void DisableChildRenderers()
    {
       
            MeshRenderer renderer1 = transform.GetChild(0).GetComponent<MeshRenderer>();
            renderer1.enabled = false;
             MeshRenderer renderer2 = transform.GetChild(1).GetComponent<MeshRenderer>();
            renderer2.enabled = false;
             MeshRenderer renderer3 = transform.GetChild(2).GetComponent<MeshRenderer>();
            renderer3.enabled = false;
             MeshRenderer renderer4 = transform.GetChild(3).GetComponent<MeshRenderer>();
            renderer4.enabled = false;
             MeshRenderer renderer5 = transform.GetChild(4).GetComponent<MeshRenderer>();
            renderer5.enabled = false;
             
     
    }

}
