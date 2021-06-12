using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 2.5f;
    public float MaxMovement = 1.5f;
    
    

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += input * Speed * Time.deltaTime;

        if (pos.x > MaxMovement)
            pos.x = MaxMovement;
        else if (pos.x < -MaxMovement)
            pos.x = -MaxMovement;

        transform.position = pos;
    }
}
