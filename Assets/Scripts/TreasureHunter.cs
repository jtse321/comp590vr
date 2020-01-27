﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunter : MonoBehaviour
{
    public collectible[] collectibles;
    public treasureHunterInventory inventory;
    // Start is called before the first frame update
    int score, number = 0;
    bool one, two, three = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            print("1");
            inventory.inInventory[0] = collectibles[0];
            one = true;
        }
        if (Input.GetKeyDown("2"))
        {
            print("2");
            inventory.inInventory[1] = collectibles[1];
            two = true;
        }
        if (Input.GetKeyDown("3"))
        {
            print("3");
            inventory.inInventory[2] = collectibles[2];
            three = true;
        }
        if (Input.GetKeyDown("4"))
        {
            score = 0;
            number = 0;
            for (int i = 0; i < 3; i++)
            {
                if (inventory.inInventory[i] != null)
                {
                    score += inventory.inInventory[i].value;
                    number++;
                }
            }
            GameObject.Find("final").GetComponent<TextMesh>().text = "You have " + number + " items with a score of " + score + "!    -Justin Tse";
        }

        if (one && two && three)
        {
            GameObject.Find("win").GetComponent<TextMesh>().text = "You win!";
        }
    }
}
