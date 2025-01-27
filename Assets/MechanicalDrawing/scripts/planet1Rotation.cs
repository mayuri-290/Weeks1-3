using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet1Rotation : MonoBehaviour
{
    public float speed = 10.0f; //the speed at which the object rotates.

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;//set and declair the variables: rot
        rot.z += speed * Time.deltaTime;//add z axis to make it rotate
        transform.eulerAngles = rot;//apply the rotation to object
    }
}
