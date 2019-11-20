using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForward : MonoBehaviour
{
    public Transform CubeDevant;
    Vector3 speed = new Vector3(0, 0, -5);

    private void OnTriggerStay(Collider other)
    {
        CubeDevant.transform.position += speed * Time.deltaTime;
    }
}
