using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Speed = 100;
    
    void Update()
    {
        Rb.MovePosition(Rb.position + Vector2.up * Speed * Time.deltaTime);
    }
     
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.CompareTag("BigCircle"))
        {
            transform.SetParent(other.transform);
        }

         else if (other.CompareTag("Pin"))
        {
            GameManager.Instance.LoseGame();
            
        }
     
     
     }

}
