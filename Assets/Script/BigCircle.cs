using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCircle : MonoBehaviour
{
   public float Speed =100;
    void Update()
    {
        transform.Rotate(0,0, Speed * Time.deltaTime);
    }
}
