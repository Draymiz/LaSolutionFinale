using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDroiteGauche : MonoBehaviour
{
    public Transform from;
    public Transform to;

    private float speed = 0.10f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //   transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, Time.deltaTime * speed);
     //   transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
