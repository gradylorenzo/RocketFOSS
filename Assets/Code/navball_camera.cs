﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navball_camera : MonoBehaviour {

    public GameObject PlayerShip;

    private void FixedUpdate()
    {
        if (PlayerShip)
        {
            this.transform.SetPositionAndRotation(transform.position, PlayerShip.transform.rotation);
        }
    }
}
