using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotDroiteCamB : MonoBehaviour
{
    public Transform CameraB;

    private void OnTriggerStay(Collider other)
    {
         CameraB.Rotate(xAngle: 0, yAngle: 20 * Time.deltaTime, zAngle: 0);
    }
   
}
