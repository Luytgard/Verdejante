using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderController : collectablesController
{
    public void OnCollisionEnter2D(Collision2D collidedObject)
    {
        if (collidedObject.gameObject.tag == "seed")
        {
            AddSeed(1);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "limbo")
        {
            Destroy(gameObject);
        }
    }
}
