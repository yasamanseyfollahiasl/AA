using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pin : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Speed = 60;
    public SpriteRenderer SpriteRenderer;
    public TMP_Text Text;
    bool _isArrived;
    public BigCircle BigCircle;
    
    void Start()
    {
      Text.text = GameManager.Instance.Pins.Count.ToString();
    }

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
             other.GetComponent<BigCircle>().UpdateText();
            if (GameManager.Instance.IsGameFinished)
            {
             GameManager.Instance.WinGame();
            }
        }
         else if (other.CompareTag("Pin"))
        {
            GameManager.Instance.LoseGame();
        }
     
     
     }

}
