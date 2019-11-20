using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotGaucheCamB : MonoBehaviour
{
    public Transform CameraB;

    private void OnTriggerStay(Collider other)
    {
        CameraB.transform.Rotate(xAngle: 0, yAngle: -20 * Time.deltaTime, zAngle: 0);
    }
}
