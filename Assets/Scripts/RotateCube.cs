using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
   

    
    void Update()
    {
        transform.Rotate(new Vector3(6, 11, 12) * Time.deltaTime);
        
    }
}
