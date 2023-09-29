using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBg : MonoBehaviour
{

    public int speed;
    public float startX;
    public float endX;

     void Update()
    {
        transform.Translate(Vector2.left * (speed + MyVars.groundSpeed) * Time.deltaTime * MyVars.stopMoving);

        if (transform.position.x <= endX)
        {
            transform.position = new Vector2(startX, transform.position.y);

        }
    }
}
