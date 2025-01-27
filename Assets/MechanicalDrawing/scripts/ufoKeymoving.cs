using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoKeymoving : MonoBehaviour
{
    public float ufoSpeed = 5.0f; //set an initial speed for the UFO

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 UFO1 = transform.position; //declaire the variable name and tell the use. For instance, make the ufo move horizontal by clicking the "a","d", and up down. 
        UFO1.x+=Input.GetAxisRaw("Horizontal") * ufoSpeed * Time.deltaTime; //activate the key using GetAxisRaw. Make the UFO move left and right over time. 
        transform.position = UFO1; //apply the updated position back to the UFO's transform component. 

        Vector2 UFO2 = transform.position; //declaire the variable name and tell the use. For instance, make the ufo move horizontal by clicking the "w","s", and left right. 
        UFO2.y += Input.GetAxisRaw("Vertical") * ufoSpeed * Time.deltaTime; //activate the key using GetAxisRaw. Make the UFO move left and right over time. 
        transform.position = UFO2; //apply the updated position back to the UFO's transform component. 


    }
}
