using UnityEngine;

public class ClapObject : MonoBehaviour
{
    // The object that will be clapped onto
    public GameObject clapTarget;

    // The position and rotation of the clap object relative to the clap target
    public Vector3 clapPosition;
    public  Transform tr;
    public Quaternion clapRotation;

    private void OnTriggerStay(Collider other)
    {
        // Check if the other object is the clap target
        if (other.gameObject == clapTarget)
        {
            // Clap the object onto the target by setting the clap target as its parent
           // transform.SetParent(clapTarget.transform, true);

            // Set the position and rotation of the clap object relative to the clap target
            transform.position = tr.position;
           // transform.localRotation = clapRotation;
        }
    }
/*
    private void OnTriggerExit(Collider other)
    {
        // Check if the other object is the clap target
        if (other.gameObject == clapTarget)
        {
            // Un-clap the object by setting its parent to null
            //transform.SetParent(null, true);

            // Set the position and rotation of the clap object back to their original values
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }
    }*/
}
