using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //The things positiions (camera) should be the same as the car's positions
    [SerializeField]GameObject followObject;

    void LateUpdate()
    {
        transform.position = followObject.transform.position + new Vector3(0,0,-10); 
    }
}
