using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectible
{
    public Sprite emptyChess;
    public int goldAmount = 5;
    protected override void onCollect()
    {   
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChess;
            Debug.Log("Grant " + goldAmount + "g");
        } 
    }
}
