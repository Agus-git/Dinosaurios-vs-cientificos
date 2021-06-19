using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemy : MonoBehaviour
{
    NavMeshAgent IA;
    public Transform objetivo;
    private Vida vida;
    bool Rompiendo = false;
    Animator anim;
    Resistencia UltimoObstaculo;
    public AudioSource[] audios;
    public AudioSource StepAudio;
    System.Random ran;
    BoxCollider box;

    void Start()
    {
        box = GetComponent<BoxCollider>();
        IA = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        vida = GetComponent<Vida>();

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
            print($"Hola, soy {this.gameObject.name} y tengo {vida.Salud}");
            UltimoObstaculo = collision.gameObject.GetComponent<Resistencia>();
            IA.isStopped = true;
            anim.SetBool("Rompiendo", true);
        }
        if (collision.gameObject.tag == "Enemigo" && vida.Salud == 0)
        {
            box.size -= new Vector3(0.1F, 0.1F, 0.1F);
            //transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F); hacer chiquito
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
            anim.SetBool("Rompiendo", false);
        }
    }
    void StepEvent()
    {
        StepAudio.Play();
    }
}
