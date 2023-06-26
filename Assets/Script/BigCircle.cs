using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BigCircle : MonoBehaviour
{
   public float Speed =100;
   public TMP_Text Text;
   private void Start()
    {
        UpdateText();  
    }
    void Update()
    {
        transform.Rotate(0,0, Speed * Time.deltaTime);
        
    }

    public void UpdateText()
    {
    Text.text = (GameManager.Instance.PinsCountToShoot - GameManager.Instance.Pins.Count).ToString();
    }

    public void AddSpeed()
    {
    Speed *= GameManager.Instance.MultipleSpeed;
    
    }
}
