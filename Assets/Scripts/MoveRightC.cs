using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightC : MonoBehaviour
{
    public Transform LeftC;
    public Transform tr;
     public Transform tr2;
     bool movingDown;
     bool movingLeft;
     bool movingUP;
     bool movingRight;
     private Vector3 OriginalPos;
     private Animator anim;
    public Transform RightC;
     public ParticleSystem craftingSmoke;
     public ParticleSystem craftingSpark;
    
    // Start is called before the first frame update
    void Start()
    {
         movingDown = false;
          movingLeft = false;
          movingUP = false;
          movingRight = false;
          OriginalPos=transform.position;
           anim=LeftC.GetComponent<Animator>();
           
    }

    // Update is called once per frame
    void Update()
    {
        movmment();
        
        back();

        if(Input.GetKeyDown(KeyCode.C)){
            RightC.Rotate(0,-45,0);
        }

    }
    private void movmment(){
         // Moves the object forward at two units per second.
        if (Input.GetKey(KeyCode.M))
        {   movingDown = true;
            
        }
        if(movingDown){
             
            transform.position = Vector3.MoveTowards(transform.position, tr.position, 3 * Time.deltaTime);   
               if (transform.position == tr.position ){
                        movingDown = false;
                         movingLeft = true;
               } 
                      }
         if(movingLeft){
             
            transform.position = Vector3.MoveTowards(transform.position, tr2.position, 3 * Time.deltaTime);   
               if (transform.position == tr2.position ){                     
                         movingLeft = false;
                          anim.SetBool("turn",true);
                            craftingSmoke.Play();
                              craftingSpark.Play();
               } 
                      }
    }

    private void back(){
         // Moves the object forward at two units per second.
        if (Input.GetKey(KeyCode.B))
        {   movingRight = true;
            
        }
        if(movingRight){
             
            transform.position = Vector3.MoveTowards(transform.position, tr.position, 3 * Time.deltaTime); 
              anim.SetBool("turn",false);
               craftingSmoke.Stop();  
                craftingSpark.Stop();
               if (transform.position == tr.position ){
                        movingRight = false;
                         movingUP = true;
               } 
                      }
         if(movingUP){
             
            transform.position = Vector3.MoveTowards(transform.position, OriginalPos, 3 * Time.deltaTime);   
               if (transform.position == OriginalPos ){                     
                         movingUP = false;
               } 
                      }
    }

}
