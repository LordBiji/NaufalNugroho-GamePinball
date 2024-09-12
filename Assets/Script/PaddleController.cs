using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;

    //menyimpan angka target position saat ditekan dan dilepas
    private float targetPressed;
    private float targetReleased;

    private HingeJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        //saat start, set kedua target tersebut
        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput(); 
    }

    private void ReadInput()
    {
        //mengambi variable spring dari start
        JointSpring jointSpring = hinge.spring;

        //membaca input dari "input"
        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetReleased;
        }

        //mengubah spring pada hinge joint dengan value yang sudah di ubah
        hinge.spring = jointSpring;
    }

    private void MovePaddle()
    {

    }
}
