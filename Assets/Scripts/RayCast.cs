using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        //checks if hdmi is looking at object on scanner layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1f,LayerMask.GetMask("scanner"))) 
        {
            //outputs message to console
            Debug.Log("hit");
        }

    }
}
