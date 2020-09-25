using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemy : MonoBehaviour
{
    NavMeshAgent IA;
    public Transform objetivo;
    bool Rompiendo = false;
    Animator anim;
    Resistencia UltimoObstaculo;
    void Start()
    {
        IA = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        IA.destination = objetivo.position;
        anim.SetBool("Rompiendo", Rompiendo);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Porton")
        {
            UltimoObstaculo = collision.gameObject.GetComponent<Resistencia>();
            IA.isStopped = true;
            Rompiendo = true;
        }
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        
        if (collisionInfo.gameObject.tag == "Porton")
        {
        }
    }
    void HitEvent()
    {
        if (UltimoObstaculo.Romper(3))
        {
            print("Paso 3");
            IA.isStopped = false;
            IA.destination = objetivo.position;
            Rompiendo = false;
        }
    }
}
