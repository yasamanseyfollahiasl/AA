using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject PinPrefab;
    int _pinsToShoot;
    int _shootedPins;
    void Update()
    {
        
       
       
       if(Input.GetMouseButtonDown(0))
      { 
        _shootedPins = GameManager.Instance.Pins.Count;
        _pinsToShoot = GameManager.Instance.PinsCountToShoot; 


        
        if (_pinsToShoot > _shootedPins)
       {
            GameObject pin = Instantiate(PinPrefab,transform.position,transform.rotation);
            GameManager.Instance.Pins.Add(pin.GetComponent<Pin>());
        } 

            if (_pinsToShoot <= _shootedPins + 1)
            {
           
            GameManager.Instance.IsGameFinished = true;
             }
           

        }
        
    }     
}
