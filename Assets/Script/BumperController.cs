using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    //menyimpan variabel bola sebagai referensi untuk pengecekan
    public Collider bola;

    //untuk mengatur warna bumper
    public Color color;

    public float multiplier;

    //komponen renderer yang akan kita ubah
    private Renderer renderir;
    private Animator animator;

    void Start()
    {
        //mengambil componenet renderer
        renderir = GetComponent<Renderer>();

        //ambil animatort
        animator = GetComponent<Animator>();

        //akses material dan ubah warna saat start
        renderir.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //memastikan yang menabrak adalah bola
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //saat ditabrak bola, mengaktifkan triger hit
            animator.SetTrigger("Hit");
        }
    }
}
