using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenaDeLaLuz : MonoBehaviour
{
    public AudioClip[] audios;
    AudioSource audio;
    Light luz;
    bool paused = true;
    float velocity = 1;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        luz = GetComponent<Light>();
        audio.Play();
        Invoke("Principio", audio.clip.length-1);
    }
    void Principio()
    {
        audio.clip = audios[0];
        audio.Play();
        Invoke("Medio", audio.clip.length-0.5f);
    }

    void Medio(){ 
        audio.clip = audios[1];
        audio.Play();
        luz.type = LightType.Point;
        paused = false;
        Invoke("CasiFinal", audio.clip.length);
    }

    void CasiFinal()
    { 
        audio.clip = audios[2];
        audio.Play();
        print("¿estoy?");
        Invoke("Fin", audio.clip.length+1);
    }

    void Update()
    {
        if(paused == false)
        {
            transform.Translate(0, 0, velocity*1.5f*Time.deltaTime);
            velocity++;
        }
    }

    void Fin(){
        Destroy(this.gameObject);
    }
}
