using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class collectablesController : MonoBehaviour
{
    public Text seedCountText;

    [SerializeField]
    private int seedCount;
    
    
    public int GetSeedCount() => this.seedCount;
    public void SetSeedCount(int seed) => this.seedCount = seed;

    public void AddSeed(int seedToAdd) => SetSeedCount(seedCount + seedToAdd);
    public void RemoveSeed(int seedToRemove) => SetSeedCount(seedCount - seedToRemove);

    private void UpdateSeedCountOnInterface(int seedCount)
    {
        seedCountText.text = seedCount.ToString();
    }
    
    public void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.gameObject.tag == "seed")
        {
            AddSeed(1);
            UpdateSeedCountOnInterface(GetSeedCount());
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            AddSeed(1);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            RemoveSeed(1);
        }
    }
}
