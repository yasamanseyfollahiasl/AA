using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   public static GameManager Instance;

    public Animator Animator;
    public BigCircle BigCircle;
    public PinSpawner PinSpawner;
    public List<Pin> Pins = new List<Pin>();
   public GameManager()
   {
    Instance = this;
   }

   public void LoseGame()
   {
   Animator.SetTrigger("GameOver");
   BigCircle.enabled = false;
   PinSpawner.enabled = false;
   for (int i = 0; i < Pins.Count; i++)
   {
      Pins[i].enabled = false;
   }

   }

   public void WinGame()
   {
   
   }
}
