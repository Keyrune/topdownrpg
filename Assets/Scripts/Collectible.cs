using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Collidable
{
    // Logic
    protected bool collected;


    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            onCollect();
        }
    }
    protected virtual void onCollect()
    {
        collected = true;
    }
}