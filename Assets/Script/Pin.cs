using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Speed = 60;
    public SpriteRenderer SpriteRenderer;
    bool _isArrived;
    
    void FixedUpdate()
    {
    if (!_isArrived)
    {
        Rb.MovePosition(Rb.position + Vector2.up * Speed * Time.fixedDeltaTime);
        }
    }
     
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.CompareTag("BigCircle"))
        {
            SpriteRenderer.enabled = true;
            transform.SetParent(other.transform);
        }

         else if (other.CompareTag("Pin"))
        {
            GameManager.Instance.LoseGame();
            
        }
     
     
     }

}
