using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class DamageZone : MonoBehaviour
{

    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;

    public void GameOver()
    {
        GameOverScreen.Setup(maxPlatform);
    }

    public float DamagePoints = 10f;

    private void OnTriggerStay(Collider other)
    {
        Health H = other.GetComponent<Health>();

        if (H == null) return;

        H.HealthPoints -= 10f * Time.deltaTime;
    }
}
