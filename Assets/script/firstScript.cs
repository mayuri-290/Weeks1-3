using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if(pos.x<-10||pos.x>Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;

    }
}
