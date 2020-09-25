using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IATorre : MonoBehaviour
{
    [Range(0, 20)]
    public float radio;
    public LayerMask layers;
    public float Latencia;
    public float Daño;
    Collider[] cols;
    DateTime TiempoDelUltimoDisparo;
    AudioSource audio;
    Vida vidaEnemiga;

    void Start()
    {
        TiempoDelUltimoDisparo = DateTime.Now;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        cols = Physics.OverlapSphere(transform.position, radio, layers);
        if (cols.Length > 0)
        {
            transform.LookAt(cols[0].transform);
            Disparo(cols[0]);
        }
    }

    private void Disparo(Collider collider)
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo);
                Debug.DrawLine(transform.position, hitInfo.point, Color.green);
        if (hitInfo.collider.Equals(collider))
        {
            TimeSpan Reloj = DateTime.Now - TiempoDelUltimoDisparo;

            if (Reloj.TotalSeconds > Latencia)
            {
                print(hitInfo.collider.name);
                audio.Play();
                vidaEnemiga = hitInfo.collider.GetComponent<Vida>();
                vidaEnemiga.ProbocarDaño(Daño);
                TiempoDelUltimoDisparo = DateTime.Now;
            }

        }
    }

    //void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(transform.position, radio);
    //}
}
