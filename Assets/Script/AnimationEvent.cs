using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationEvent : MonoBehaviour
{
   public void RestartLevel()
   {
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   } 

   public void SavePlayer()
   {
    PlayerPrefs.SetInt("OurLevel",SceneManager.GetActiveScene().buildIndex +1);
    SceneManager.LoadSceneAsync(0);
   }
}
