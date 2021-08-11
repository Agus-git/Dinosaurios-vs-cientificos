using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Text;

public class Vida : MonoBehaviour
{
    public float Salud;
    Animator anim;
    NavMeshAgent IA;
    Rigidbody rig;
    NavMeshObstacle obstacle;

    void Start()
    {
        anim = GetComponent<Animator>();
        IA = GetComponent<NavMeshAgent>();
        rig = GetComponent<Rigidbody>();
        obstacle = GetComponent<NavMeshObstacle>();
    }

    public void ProbocarDaño(float Potencia)
    {
        Salud -= Potencia;
        if (Salud <= 0)
        {
            Morir(anim == null);
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
            List<int> NotasDeMemoria = Memoria.Notas();
            NotasDeMemoria.Add(10);
            Memoria.Cambiador(NotasDeMemoria);
            obstacle.enabled = true;
            IA.enabled = false;
            anim.SetBool("Muerto",true);
            this.gameObject.layer = 0;
            Destroy(this.gameObject, 15);
            Destroy(rig);
        }
    }
}
