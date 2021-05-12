using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
 public void PlayGame()
 {
        Debug.Log("play");
        SceneManager.LoadScene("Temple Clean Jungle");
 }

 public void QuitGame()
 {
        Debug.Log("Quitting!");
        Application.Quit();
 }
}
