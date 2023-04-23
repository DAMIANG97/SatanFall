using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsound : MonoBehaviour
{
    [SerializeField] private AudioSource jumpOnCloudSoundEffect;



    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        jumpOnCloudSoundEffect.Play();
    }
    }
