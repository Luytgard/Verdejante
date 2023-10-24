using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject winScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            winScreen.gameObject.SetActive(true);
        }
    }
}
