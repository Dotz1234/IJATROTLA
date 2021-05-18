using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float StartingHealth = 100f;

    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;
    public float HealthPoints
    {
        get { return _HealthPoints; }
        set
        {
            _HealthPoints = Mathf.Clamp(value, 0f, 100f);

            if (_HealthPoints <= 0f)
            {
                Die();
                GameOver();
            }
        }
    }

    [SerializeField]
    private float _HealthPoints = 100f;

    void Start()
    {
        HealthPoints = StartingHealth;
    }

    void Die()
    {
        Destroy(gameObject);
    }
    public void GameOver()
    {
        GameOverScreen.Setup(maxPlatform);
    }
}
