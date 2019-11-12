using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuit : MonoBehaviour
{
    public Transform Soleil;
    private float Speed = 30;

    private float MoveSpeedSun = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Soleil.Rotate(xAngle: MoveSpeedSun * Time.deltaTime, yAngle: 0, zAngle: 0);
    }

    private void OnTriggerStay(Collider other)
    {
        Soleil.Rotate(xAngle: -18 * Time.deltaTime, yAngle: 0, zAngle: 0);
    }
}
