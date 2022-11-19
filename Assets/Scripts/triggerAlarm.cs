using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAlarm : MonoBehaviour
{
    Animator animator;
    public AudioSource Alarm;
    void Start()
    {
        
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            animator.SetBool("AlarmTriggered", true);
            Alarm.Play();
        }else if (Input.GetKeyUp("space")){
             animator.SetBool("AlarmTriggered", false);
            Alarm.Stop();
        }
    }
}
