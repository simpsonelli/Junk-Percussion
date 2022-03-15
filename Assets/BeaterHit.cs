using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaterHit : MonoBehaviour
{
    public AudioSource audioSource;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beater");
        audioSource.Play();
    }
}
