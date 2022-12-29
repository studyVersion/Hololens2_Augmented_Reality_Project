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
     public ParticleSystem escape;
     bool call = false;
     bool callback = false;
    // Start is called before the first frame update
    void Start()
    {
         movingDown = false;
          movingLeft = false;
          movingUP = false;
          movingRight = false;
          OriginalPos=transform.position;
           anim=LeftC.GetComponent<Animator>();
           escape.Stop();
           
    }
    

    public void click(){
         if(!call){
            call = true;
         }
    }
    public void clickback(){
         if(!callback){
            callback = true;
         }
    }
    // Update is called once per frame
    void Update()
    {  
        if(call)    { movmment(); }
        if(callback)   { back(); }

        if(Input.GetKeyDown(KeyCode.C)){
            RightC.Rotate(0,-45,0);
        }

    }
    private void movmment(){
         // Moves the object forward at two units per second.
        if (call)
        {   movingDown = true;
            
        }
        if(movingDown){
             
            transform.position = Vector3.MoveTowards(transform.position, tr.position, 0.3f * Time.deltaTime);   
               if (transform.position == tr.position ){
                        movingDown = false;
                         movingLeft = true;
               } 
                      }
         if(movingLeft){
             
            transform.position = Vector3.MoveTowards(transform.position, tr2.position, 1 * Time.deltaTime);   
               if (transform.position == tr2.position ){                     
                         movingLeft = false;
                          anim.SetBool("turn",true);
                            craftingSmoke.Play();
                              craftingSpark.Play();
                              escape.Play();
                              call=false;
               } 
                      }
    }

    private void back(){
         // Moves the object forward at two units per second.
        if (callback)
        {   movingRight = true;
            
        }
        if(movingRight){
             
            transform.position = Vector3.MoveTowards(transform.position, tr.position, 0.2f * Time.deltaTime); 
              anim.SetBool("turn",false);
               craftingSmoke.Stop();  
                craftingSpark.Stop();
                escape.Stop();
               if (transform.position == tr.position ){
                        movingRight = false;
                         movingUP = true;
               } 
                      }
         if(movingUP){
             
            transform.position = Vector3.MoveTowards(transform.position, OriginalPos, 1 * Time.deltaTime);   
               if (transform.position == OriginalPos ){                     
                         movingUP = false;
                         callback=false;
               } 
                      }
    }

}
