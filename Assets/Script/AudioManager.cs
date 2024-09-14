using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // kita masukan audio source bgm disini
    public AudioSource bgmAudioSource;

    // kita masukan game object sfx disini
    public GameObject sfxAudioSource;
    public GameObject sfxAudioSource2;
    public GameObject sfxAudioSource3;  

    private void Start()
    {
        // jalankan BGM saat game dimulai
        PlayBGM();
    }

    // fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
    public void PlayBGM() 
    {
        // kita tinggal tambahkan saja fungsi untuk memainkan audio source bgm nya
        bgmAudioSource.Play();
    }
    // fungsi yang disiapkan untuk perintah menjalankan sfx dari script lain
    // ini tidak di jalankan pada script ini, tapi nanti di jalankan pada script bumpernya
    public void PlaySFX(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
        // memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFX2(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
        // memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(sfxAudioSource2, spawnPosition, Quaternion.identity);
    }

    public void PlaySFX3(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
        // memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(sfxAudioSource3, spawnPosition, Quaternion.identity);
    }

}
