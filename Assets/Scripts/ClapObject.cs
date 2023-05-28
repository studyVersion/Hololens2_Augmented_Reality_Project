using System.Collections;
using UnityEngine;

public class ClapObject : MonoBehaviour
{
    // The object that will be clapped onto
    public GameObject clapTarget;
    public GameObject instanciate;
    public GameObject fatherObject;
    public Transform targetPosition;

    public GameObject containerObject; // Static reference to the container object



    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object is the clap target
        if (other.gameObject == clapTarget)
        {

            transform.position = targetPosition.position;
            transform.rotation = targetPosition.rotation;

            // Set the ClapObject's parent to the container object
            transform.SetParent(containerObject.transform);
            
        }

        if (other.gameObject == instanciate)
        {
            if (containerObject.transform.childCount > 0)
            {   
                
                // Iterate over each child object and destroy them
                for (int i = containerObject.transform.childCount - 1; i >= 0; i--)
                {
                    GameObject childObject = containerObject.transform.GetChild(i).gameObject;
                    
                    Destroy(childObject);
                }
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the other object is the clap target
        if (other.gameObject == clapTarget)
        {
            transform.SetParent(null);

        }


    }


}