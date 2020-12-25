using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One : MonoBehaviour
{
    [Range(0,10)]public float speed;
    void Start()
    {
        speed = speed * 10;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    void movement() 
    {
        float moveH = Input.GetAxis("Horizontal")*speed;
        float moveV = Input.GetAxis("Vertical")*speed;
        Vector3 vector = new Vector3(moveH * Time.deltaTime, 0, moveV * Time.deltaTime);
        transform.Translate(vector);
    }
}
