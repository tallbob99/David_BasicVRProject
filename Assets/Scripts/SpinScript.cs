using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SpinScript : MonoBehaviour
{
    public SteamVR_Action_Single spinAction;
    public float rotateSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if trigger is being pulled
        if (spinAction.axis > 0)
        {
           //rotates object relative to pressure aplied to trigger
            transform.Rotate(0, spinAction.axis * rotateSpeed, 0, Space.Self);
        }
        
    }
}
