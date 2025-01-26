using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bouncingBall : MonoBehaviour
{

    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {


       // transform.localScale=Vector2.one* curve.Evaluate(t);
       // Vector2 scale = transform.localScale;
       //float x = Mathf.Lerp(0, 1, t);
       // transform.position = Vector2.Lerp(start, end, t);

        Vector3 pos = transform.position;
        pos.x += speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x<0 || screenPos.x>Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;

   

    }

   
}
