using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Vida : MonoBehaviour
{
    public float Salud;
    Animator anim;
    NavMeshAgent IA;
    Rigidbody rig;

    void Start()
    {
        anim = GetComponent<Animator>();
        IA = GetComponent<NavMeshAgent>();
        rig = GetComponent<Rigidbody>();
    }

    public void ProbocarDaño(float Potencia)
    {
        Salud -= Potencia;
        if (Salud <= 0)
        {
            Morir(anim == null);
            IA.isStopped = true;
        }
    }

    private void Morir(bool v)
    {
        if (v)
        {
            Destroy(this.gameObject);
        }
        else
        {
            anim.SetBool("Muerto",true);
            this.gameObject.layer = 0;
            Destroy(this.gameObject, 15);
            Destroy(rig);
        }
    }
}
