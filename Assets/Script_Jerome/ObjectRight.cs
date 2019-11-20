using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRight : MonoBehaviour
{
    public Transform CubeDroite;
    Vector3 speed = new Vector3(-5, 0, 0);

    private void OnTriggerStay(Collider other)
    {
        CubeDroite.transform.position += speed * Time.deltaTime;
    }
}
