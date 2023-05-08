using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   public static GameManager Instance;

    public Animator Animator;
    public BigCircle BigCircle;
    public PinSpawner PinSpawner;
   public GameManager()
   {
    Instance = this;
   }

   public void LoseGame()
   {
   Animator.SetTrigger("GameOver");
   BigCircle.enabled = false;
   PinSpawner.enabled = false;

   }

   public void WinGame()
   {
   
   }
}
