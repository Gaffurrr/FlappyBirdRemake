using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addscore : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip ScoreClip;
    public AudioClip DeathSound;
    public GameManager gameManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Audio.clip = ScoreClip;
        Audio.Play();

        Score.score++;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Audio.clip = DeathSound;
        Audio.Play();

        gameManager.GameOver();
    }
}
