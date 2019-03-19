using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public float timer,speed,height,width;
    

    void Start()
    {
        speed = 5;
        height = 4;
        width= 7;
    }
    void Update()
    {
        float x = Mathf.Cos(timer)*width;
        float y = 0;
        float z = Mathf.Sin(timer) * height;
        timer += Time.deltaTime*speed;
        transform.position = new Vector3(x, y, z);
    }
}
