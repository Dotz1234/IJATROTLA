using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOptions : MonoBehaviour
{
    private void Start()
    {
        HealthController healthSystem = new HealthController(100);

        Debug.Log("Health: " + healthSystem.GetHealth());
    }


}
