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
            GameManager.instance.ShowText("+" + goldAmount + " gold!", 25, Color.yellow, transform.position, Vector3.up * 100, 0.5f);
        } 
    }
}
