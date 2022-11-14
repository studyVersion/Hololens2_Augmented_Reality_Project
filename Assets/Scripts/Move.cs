using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform doorPosition;
    public Transform targetPosition;
    private Vector3 referencia;
    public float speed;
    public AudioSource doorAudio;

    bool opening;
    bool moving;

    // Start is called before the first frame update
    void Start()
    {    
         moving= false;
         opening= false;
         referencia = doorPosition.position;

    }



    void Update()
    {
        // Moves the object forward at two units per second.
        if (Input.GetKey(KeyCode.LeftArrow) )
        {   
            moving = true;
            opening= true;
            
        }
        if (Input.GetKey(KeyCode.RightApple) ){
            moving =true;
            opening = false;
        }
    
        if(moving && opening){
             
             move(doorPosition.position, targetPosition.position);   
               if (doorPosition.position == targetPosition.position ){
                        moving = false;   
               }
             
            
        }
      
        if(moving && !opening){

             move(doorPosition.position, referencia);
           if(doorPosition.position == referencia){
                 moving =false;
           }
            
        }
        

        // // el sonido sólo se activa cuando se pulsan los botones izquierdo/derecho
        // if (movingRight)
        // {
        //     doorAudio.Play();
        // }
      
        // if (!movingRight)
        // {
        //     doorAudio.Stop();
        // }

    }

    void move(Vector3 pos, Vector3 target){
        doorPosition.position = Vector3.MoveTowards(pos, target,speed * Time.deltaTime);
    }


}