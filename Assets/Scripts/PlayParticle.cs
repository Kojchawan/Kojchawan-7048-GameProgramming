using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem isParticle;

    private void Awake()
    {
        isParticle = gameObject.GetComponent<ParticleSystem>();
    }

    private void OnEnable()
    {
        isParticle.Play();
    }
}
