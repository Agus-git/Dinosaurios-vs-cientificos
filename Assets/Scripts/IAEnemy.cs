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
    public AudioSource[] audios;
    public AudioSource StepAudio;
    System.Random ran;
    void Start()
    {
        IA = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        ran = new System.Random();
        IA.destination = objetivo.position;
        anim.SetBool("Rompiendo", Rompiendo);
    }

    // Update is called once per frame
    void Update()
    {
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
    void HitEvent()
    {
        audios[ran.Next(audios.Length)].Play();
        if (UltimoObstaculo.Romper(3))
        {
            print("Paso 3");
            IA.isStopped = false;
            IA.destination = objetivo.position;
            Rompiendo = false;
        }
    }
    void StepEvent()
    {
        StepAudio.Play();
    }
}
