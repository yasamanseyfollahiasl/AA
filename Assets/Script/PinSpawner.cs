using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
   

    public GameObject PinPrefab;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        Instantiate(PinPrefab,transform.position,transform.rotation);
        }
    }
}
