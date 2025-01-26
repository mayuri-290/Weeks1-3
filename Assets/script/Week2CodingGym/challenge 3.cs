using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class challenge3 : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);

       // transform.position = Vector3.zero;
       // transform.eulerAngles = Vector3.zero;
       // transform.rotation = Quaternion.identity;

       // transform.localPosition = Vector3.zero;
       //transform.localEulerAngles = Vector3.zero;
       // transform.localRotation = Quaternion.identity;
    }
}
