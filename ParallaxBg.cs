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
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endX)
        {
            transform.position = new Vector2(startX, transform.position.y);

        }
    }
}
