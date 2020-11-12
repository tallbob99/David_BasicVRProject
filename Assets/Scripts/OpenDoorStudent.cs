using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorStudent : MonoBehaviour
{
    public bool unlocked = false;
    private Vector3 startPos;
    private Vector3 endPos;
    public float doorOpenSpeed = 1.5f;
    public GameObject door;

    private void Start()
    {
        // sets the starting and open position of the door
        startPos = door.transform.position;
        endPos = new Vector3(door.transform.position.x - 3.5f, door.transform.position.y, door.transform.position.z);
    }

    IEnumerator MoveDoor(Vector3 start, Vector3 end)
    {
        float elapsedTime = 0f;
        // while the elapsed time is less than 1.5, keep moving the door
        // if you want the door to open faster/slower, change the 1.5f value
        while (elapsedTime < doorOpenSpeed)
        {
            // move the door smoothly using Lerp
            // learn more about Lerp here: https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
            door.transform.position = Vector3.Lerp(start, end, (elapsedTime / doorOpenSpeed));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
