using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform doorPosition;
    public Transform targetPosition;
    private Vector3 referencia;
    public float speed =1f;
    public AudioSource doorAudio;

    public GameObject luzInterior;
    public GameObject luzExterior;
    bool click = false;
  

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

    public void clickMe(){
        if(click == false){
            click =true;
        }else{
            click = false;
        }
    }

    void Update()
    {
        if(click){
        // Moves the object forward at two units per second.
        // if (Input.GetKey(KeyCode.LeftArrow) && !closing )
        if (!closing )
        {   
            opening= true;
            doorAudio.Play();
        }

        // if (Input.GetKey(KeyCode.RightArrow) && !opening ){
        //     closing =true;
        //     doorAudio.Play();
        // }
       
        if(opening){      

             luzInterior.SetActive(false);
             luzExterior.SetActive(false);
             
            
            
            

             move(doorPosition.position, targetPosition.position);             
               if (doorPosition.position == targetPosition.position ){
                        opening = false;


               }            
            
        }
        }
        if(!click){
       if (!opening ){
            closing =true;
            doorAudio.Play();
        }
        if(closing){
             
             move(doorPosition.position, referencia);
             
           if(doorPosition.position == referencia){
                reset();

                luzInterior.SetActive(true);
                luzExterior.SetActive(true);
              
                 //LeftC.transform.Rotate(0,40,0);
 
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
    }
    void reset(){
         opening= false;
         closing = false;
    }
    void move(Vector3 pos, Vector3 target){
        doorPosition.position = Vector3.MoveTowards(pos, target,speed * Time.deltaTime);
    }
 
}