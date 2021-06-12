using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : MonoBehaviour
{
   
    void Update()
    {

        transform.Rotate(new Vector3(0, 11, 0) * Time.deltaTime); 
    }
}
