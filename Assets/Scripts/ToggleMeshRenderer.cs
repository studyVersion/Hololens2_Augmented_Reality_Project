using System.Collections;
using UnityEngine;

public class ToggleMeshRenderer : MonoBehaviour
{
    bool shapedOne = false;
    bool shapedTwo = false;
    bool shapedThree = false;
    bool shapedFour = false;
    bool alarmButton = false;
    GameObject childObject;
    GameObject childObject2;
    MeshRenderer[] meshRenderer;
    bool gotChild = false;
    private Coroutine coroutine;
    void Start()
    {

        gotChild = false;
        // Check if the parent object has at least one child
        if (transform.childCount > 0)
        {
            // Get the first child object
            childObject = transform.GetChild(0).gameObject;

            if (childObject.transform.childCount > 0)
            {
                childObject2 = childObject.transform.GetChild(0).gameObject;
                meshRenderer = childObject2.GetComponentsInChildren<MeshRenderer>();

            }


        }

    }


    void ResetRenderer()
    {
        if (childObject2 != null)
        {
            for (int i = 0; i < childObject2.transform.childCount; i++)
            {
                MeshRenderer renderer = childObject2.transform.GetChild(i).GetComponent<MeshRenderer>();
                if (renderer != null)
                    renderer.enabled = false;
            }

            if (childObject2.transform.childCount > 0)
            {
                MeshRenderer firstRenderer = childObject2.transform.GetChild(0).GetComponent<MeshRenderer>();
                if (firstRenderer != null)
                    firstRenderer.enabled = true;
            }
        }
    }

    void Update()
    {
        // Check if the parent object has at least one child
        if (transform.childCount > 0)
        {
            // Get the first child object
            childObject = transform.GetChild(0).gameObject;

            if (childObject.transform.childCount > 0)
            {
                childObject2 = childObject.transform.GetChild(0).gameObject;
                meshRenderer = childObject2.GetComponentsInChildren<MeshRenderer>();
                gotChild = true;
                
            }
            else
            {

                childObject2 = null;
                gotChild = false;
            }

        }
        if (!gotChild)
        {
            ResetRenderer();
        }
        else
        {
            if (shapedOne)
            {
                
                // Enable the MeshRenderer of the second child object after 10 seconds
                coroutine = StartCoroutine(Delay1(10.0f));
                shapedOne = false;
            }
            else if (shapedTwo)
            {

                coroutine = StartCoroutine(Delay2(10.0f));
                shapedTwo = false;
                
            }
            else if (shapedThree)
            {

                coroutine = StartCoroutine(Delay3(10.0f));
                shapedThree = false;
            }
            else if (shapedFour)
            {

                coroutine = StartCoroutine(Delay4(10.0f));
                shapedFour = false;
            }
            else if (alarmButton)
            {
                StopCoroutine(coroutine);
                ResetRenderer();
                alarmButton = false;
            }
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
            alarmButton = false;


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
            alarmButton = false;

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
            alarmButton = false;
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
            alarmButton = false;
        }
    }

    public void alarm()
    {
        // doorAudio.Play();
        if (!alarmButton)
        {
            shapedOne = false;
            shapedTwo = false;
            shapedThree = false;
            shapedFour = false;
            alarmButton = true;
        }
    }


    IEnumerator Delay1(float time)
    {
        yield return new WaitForSeconds(time);
        if (childObject.transform.childCount > 0 && gotChild)
        {

            MeshRenderer renderer1 = childObject2.transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
            renderer1.enabled = false;

            MeshRenderer renderer = childObject2.transform.GetChild(1).GetComponent<MeshRenderer>();
            renderer.enabled = true;
        }
    }
    IEnumerator Delay2(float time)
    {
        yield return new WaitForSeconds(time);

        if (childObject.transform.childCount > 0)
        {
            MeshRenderer renderer1 = childObject2.transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
            renderer1.enabled = false;

            MeshRenderer renderer = childObject2.transform.GetChild(2).GetComponent<MeshRenderer>();
            renderer.enabled = true;
        }
    }
    IEnumerator Delay3(float time)
    {
        yield return new WaitForSeconds(time);
        if (childObject.transform.childCount > 0)
        {

            MeshRenderer renderer1 = childObject2.transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
            renderer1.enabled = false;

            MeshRenderer renderer = childObject2.transform.GetChild(3).GetComponent<MeshRenderer>();
            renderer.enabled = true;
        }
    }
    IEnumerator Delay4(float time)
    {
        yield return new WaitForSeconds(time);
        if (childObject.transform.childCount > 0)
        {

            MeshRenderer renderer1 = childObject2.transform.GetChild(GetCurrentShapeIndex()).GetComponent<MeshRenderer>();
            renderer1.enabled = false;

            MeshRenderer renderer = childObject2.transform.GetChild(4).GetComponent<MeshRenderer>();
            renderer.enabled = true;
        }
    }

    public int GetCurrentShapeIndex()
    {

        int currentIndex = -1;
        meshRenderer = childObject2.GetComponentsInChildren<MeshRenderer>();
        // Loop through all MeshRenderers and find the index of the currently enabled one
        if (meshRenderer != null)
        {
            for (int i = 0; i < meshRenderer.Length; i++)
            {
                if (meshRenderer[i].enabled)
                {
                    currentIndex = i;
                    break;
                }
            }

        }

        return currentIndex;
    }
}
