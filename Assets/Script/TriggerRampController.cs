using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider bola;
    public ScoreManager scoreManager;
    public AudioManager audioManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            //tambah skor kalau terkena bola
            scoreManager.AddScore(score);


            // kita jalankan SFX saat tabrakan dengan bola pada posisi tabrakannya
            audioManager.PlaySFX3(other.transform.position);
        }
    }
}
