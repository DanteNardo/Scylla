﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyScript : MonoBehaviour {

    public GameObject blood;

    // Use this for initialization
    void Start()
    {

    }

    public void IsEaten()
    {
        blood.active = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
