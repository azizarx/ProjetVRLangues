using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsScript : MonoBehaviour
{
    private ParticleSystem[] ParticleSystems;
    private AudioSource AudioSource;



    private void Start()
    {
        ParticleSystems = GetComponentsInChildren<ParticleSystem>();
        AudioSource = GetComponent<AudioSource>();
    }
    public void ClickTrigger()
    {
        foreach (ParticleSystem p in ParticleSystems) 
        {
            p.Play();
        }
        if (AudioSource != null)
        AudioSource.Play();
        Invoke("StopWords",3f);
    }
    private void StopWords()
    {
        foreach (ParticleSystem p in ParticleSystems)
        {
            p.Stop();
        }
        if(AudioSource != null)
        AudioSource.Stop();
    }
}
