using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
  //  public GameObject PointB;
    public Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.position = new Vector3(1,1,1);
            Debug.Log("Hello");
        }
    }

 /*   void OnTriggerEnter(Collision other)
    {
        // Si le joueur entre dans le collider ça le tp 
        transform.position = transform.PointB;
    }*/

    
}
