using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform doorPosition;
    public Transform targetPosition;
    private Vector3 referencia;
    public float speed =2.2f;
    public AudioSource doorAudio;

    public GameObject luzInterior;
    public GameObject luzExterior;

    public ParticleSystem escape;

    public ParticleSystem craftingSmoke;
    public ParticleSystem craftingSpark;

    bool opening;
    bool closing;


    // Start is called before the first frame update
    void Start()
    {    

         opening= false;
         closing = false;
         referencia = doorPosition.position;
        
        
         luzInterior.SetActive(true);
         luzExterior.SetActive(true);

    }



    void Update()
    {
        
        // Moves the object forward at two units per second.
        if (Input.GetKey(KeyCode.LeftArrow) && !closing )
        {   
            opening= true;
            doorAudio.Play();
        }

        if (Input.GetKey(KeyCode.RightArrow) && !opening ){
            closing =true;
            doorAudio.Play();
        }
       
        if(opening){      

             luzInterior.SetActive(false);
             luzExterior.SetActive(false);
             
             escape.Stop();
            
            

             move(doorPosition.position, targetPosition.position);             
               if (doorPosition.position == targetPosition.position ){
                        opening = false;


               }            
            
        }
      
        if(closing){
             
             move(doorPosition.position, referencia);
             
           if(doorPosition.position == referencia){
                reset();

                luzInterior.SetActive(true);
                luzExterior.SetActive(true);
                 //LeftC.transform.Rotate(0,40,0);
                escape.Play();
              
              
           }
            
        }
        

        // // el sonido sólo se activa cuando se pulsan los botones izquierdo/derecho
    //   if (moving)
    //      {
    //          doorAudio.Play();
    //     }
      
        // if (!movingRight)
        // {
        //     doorAudio.Stop();
        // }

    }
    void reset(){
         opening= false;
         closing = false;
    }
    void move(Vector3 pos, Vector3 target){
        doorPosition.position = Vector3.MoveTowards(pos, target,speed * Time.deltaTime);
    }
 
}