using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBackward : MonoBehaviour
{
    public Transform CubeArriere;
    Vector3 speed = new Vector3(0, 0, 5);
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        CubeArriere.transform.position += speed * Time.deltaTime;
    }
}
