using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class starMove : MonoBehaviour
{
    public AnimationCurve curve; //To control how the slop speed behaves of the object in unity.

    bool back = false;//track if the animation of object is reversing(moving back)

    [Range(0,1)]//range of t value
    public float t;//a value between 0-1 for the curve.
    public float speed;//set the speed at which the object moves horizontally.

    public Vector2 start;//starting position for object
    public Vector2 end;//end position for object

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;//current position of the object


        if (back == false)//if the object is moving forward along the curve
        {
            t += Time.deltaTime;//move right
        }
        else
        {
            t -= Time.deltaTime;//if not meet the above condition, move left(backwards)
        }

        if(t>=1)//set he condition of t below
        {
           back = true;
        }
        if(t<=0)
        {
            back = false;
        }
        transform.position = pos;//apply the horizontal movement to the object's position

        Vector2 scale = transform.localScale;//store the current scale.
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));//add start, end to the unity.
        transform.localScale = scale;//apply the updated data back
    }
}
