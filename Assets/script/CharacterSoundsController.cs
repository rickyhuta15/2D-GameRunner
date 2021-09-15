﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundsController : MonoBehaviour
{
    public AudioClip jump;
    private AudioSource audioPlayer;

   private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }
}
