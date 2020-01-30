using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    
    public static AudioClip playerHitSound, fireSound, jumpSound, enemyDeathSound, collectSound;
    static AudioSource audioSrc; 

    
    void Start() {

        playerHitSound = Resources.Load<AudioClip> ("playerHit");
        fireSound = Resources.Load<AudioClip> ("fire");
        jumpSound = Resources.Load<AudioClip> ("jump");
        enemyDeathSound = Resources.Load<AudioClip> ("enemyDeath");
        collectSound = Resources.Load<AudioClip> ("collectSound");  

        audioSrc = GetComponent<AudioSource> ();         
    
    }

    // Update is called once per frame
    void Update() {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
        case "fire":
            audioSrc.PlayOneShot (fireSound);
            break;
        case "playerHit":
            audioSrc.PlayOneShot (playerHitSound);
            break;
        case "jump":
            audioSrc.PlayOneShot (jumpSound);
            break;
        case "enemyDeath":
            audioSrc.PlayOneShot (enemyDeathSound);
            break;
        case "collectSound":
            audioSrc.PlayOneShot (collectSound);
            break;        
        }
    }

}
