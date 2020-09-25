using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistencia : MonoBehaviour
{
    public float resistencia;
    public GameObject[] Rejas;
    Rigidbody rig = null;
    public BoxCollider collider;
    

    internal bool Romper(int v)
    {
        resistencia -= v;
        if (resistencia <= 0)
        {
            foreach (var item in Rejas)
            {
                rig = item.GetComponent<Rigidbody>();
                rig.isKinematic = false;
            }
            collider.isTrigger = true;
            collider.enabled = false;
            return true;
        }
        return false;
    }
}
