using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Position of the camera = position of the target + offset => This will have to be done in the update

    private void Update(){ 
        transform.position = target.position + offset;
    }
}
