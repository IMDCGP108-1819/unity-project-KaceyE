﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectilePreFab;
    public Transform firepoint;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))

        {
            Shoot();

        }
    }

    void Shoot()
    {
        Instantiate(projectilePreFab, firepoint.position, firepoint.rotation);

    }




}





