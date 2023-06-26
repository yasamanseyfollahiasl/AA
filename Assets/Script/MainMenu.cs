using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text Text;
    private void Start()
    {
       Text.text = PlayerPrefs.GetInt("OurLevel",1).ToString();
    }
    public void ExitGame()
    {
    Application.Quit();
    }

    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
       ExitGame();
    }
    public void LoadLevel()
    {
      int LevelToLoad = PlayerPrefs.GetInt("OurLevel",1);
      SceneManager.LoadSceneAsync(LevelToLoad);
    }





}
