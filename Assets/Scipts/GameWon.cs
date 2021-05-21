using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    public GameObject EndScrn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EndScrn.gameObject.SetActive(true);
        }
    }
    public void Setup(int scrore)
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

