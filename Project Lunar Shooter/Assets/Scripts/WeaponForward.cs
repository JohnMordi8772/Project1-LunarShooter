﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponForward : MonoBehaviour
{
    public float speed = 25;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}