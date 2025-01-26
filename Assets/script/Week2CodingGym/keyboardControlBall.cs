using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardControlBall : MonoBehaviour
{
    public float speed = 3f;
    public float ballSize = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //keyboard control
        transform.Translate(0, Input.GetAxisRaw("Vertical") *speed * Time.deltaTime, 0);

        if (Input.GetKeyUp("up")) 
        {
            ballSize += 0.1f;
            transform.localScale = Vector3.one * ballSize;

        }
        if (Input.GetKeyUp("down"))
        {
            ballSize += 0.1f;
            transform.localScale = Vector3.one * ballSize;

        }



    }
}


   

