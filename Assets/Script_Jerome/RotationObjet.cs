using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObjet : MonoBehaviour
{
    private float speed = 50f;

    void Start()
    {
        
    }

    // Faire une list et réunir tous les GameObject utilisant la méthode update. cela consomme moins
    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);

    }
}
