using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLeft : MonoBehaviour
{
    public Transform CubeGauche;
    Vector3 speed = new Vector3(3, 0, 0);

    private void OnTriggerStay(Collider other)
    {
        CubeGauche.transform.position += speed * Time.deltaTime;
    }
}
