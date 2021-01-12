﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackMarket : MonoBehaviour
{
    GameObject[] Items;

    // Start is called before the first frame update
    void Start()
    {
        Items = GameObject.FindGameObjectsWithTag("Item");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Items[0].transform.position = this.transform.position;
        }
    }
}
