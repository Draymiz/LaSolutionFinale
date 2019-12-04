using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject PointB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.position = PointB.transform.position;
            Debug.Log("Hello");
        }
    }

  /*  void OnTriggerEnter(Collision other)
    {
        if(other)
        {
           
        }
        // Si le joueur entre dans le collider ça le tp 
        transform.position = transform.PointB;
    }*/

    
}
