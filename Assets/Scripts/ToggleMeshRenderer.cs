using System.Collections;
using UnityEngine;

public class ToggleMeshRenderer : MonoBehaviour
{
    bool shapedOne = false;
    bool shapedTwo = false;
    bool shapedThree = false;
    bool shapedFour = false;
    public Renderer[] renderers ;
 
    void Update()
    {
        if (shapedOne)
        {
            // Enable the MeshRenderer of the second child object after 10 seconds
            StartCoroutine(Delay1(10.0f));
        }
        else if(shapedTwo){

            StartCoroutine(Delay2(10.0f));
        }
        else if(shapedThree){
            
            StartCoroutine(Delay3(10.0f));
        }
        else if (shapedFour){

             StartCoroutine(Delay4(10.0f));
        }


    }

    public void shapeObjectOne()
    {
        // doorAudio.Play();
        if (!shapedOne)
        {
            shapedOne = true;
            shapedTwo = false;
            shapedThree = false;
            shapedFour = false;
            
        }
    }
     public void shapeObjectTwo()
    {
        // doorAudio.Play();
        if (!shapedTwo)
        {
            shapedOne = false;
            shapedTwo = true;
            shapedThree = false;
            shapedFour = false;
        }
    }
     public void shapeObjectThree()
    {
        // doorAudio.Play();
        if (!shapedThree)
        {
            shapedOne = false;
            shapedTwo = false;
            shapedThree = true;
            shapedFour = false;
        }
    }
    
     public void shapeObjectFour()
    {
        // doorAudio.Play();
        if (!shapedFour)
        {   
            shapedOne = false;
            shapedTwo = false;
            shapedThree = false;
            shapedFour = true;
        }
    }
    IEnumerator Delay1(float time)
    {
        yield return new WaitForSeconds(time);

        MeshRenderer renderer1 = transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
        renderer1.enabled = false;

        MeshRenderer renderer = transform.GetChild(1).GetComponent<MeshRenderer>();
        renderer.enabled = true;
    }
    IEnumerator Delay2(float time)
    {
        yield return new WaitForSeconds(time);

        MeshRenderer renderer1 = transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
        renderer1.enabled = false;

        MeshRenderer renderer = transform.GetChild(2).GetComponent<MeshRenderer>();
        renderer.enabled = true;
    }
    IEnumerator Delay3(float time)
    {
        yield return new WaitForSeconds(time);

        MeshRenderer renderer1 = transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
        renderer1.enabled = false;

        MeshRenderer renderer = transform.GetChild(3).GetComponent<MeshRenderer>();
        renderer.enabled = true;
    }
      IEnumerator Delay4(float time)
    {
        yield return new WaitForSeconds(time);

        MeshRenderer renderer1 = transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
        renderer1.enabled = false;

        MeshRenderer renderer = transform.GetChild(4).GetComponent<MeshRenderer>();
        renderer.enabled = true;
    }

    public int GetCurrentShapeIndex()
    {   
        
        int currentIndex = -1;

        // Loop through all MeshRenderers and find the index of the currently enabled one
        for (int i = 0; i < renderers.Length; i++)
        {
            if (renderers[i].enabled)
            {
                currentIndex = i;
                break;
            }
        }

        return currentIndex;
    }
}
