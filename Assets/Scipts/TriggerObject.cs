using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    public GameObject adBoard;

    private void OnTriggerEnter(Collider other)
    {
        adBoard.SetActive(true);
    }
}
