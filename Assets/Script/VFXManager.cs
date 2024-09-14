using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    public GameObject vfxSource2;

    public void PlayVFX(Vector3 spawnPosition)
    {
        // spawn vfx pada posisi sesuai parameter
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }

    // Fungsi untuk memainkan VFX kedua
    public void PlayVFX2(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource2, spawnPosition, Quaternion.identity);
    }
}
