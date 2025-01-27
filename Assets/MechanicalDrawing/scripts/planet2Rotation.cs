using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet2Rotation : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += speed * Time.deltaTime;
        transform.eulerAngles = rot;
    }
}
