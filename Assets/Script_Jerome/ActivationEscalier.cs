using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationEscalier : MonoBehaviour
{
    public GameObject Escal1;
    public GameObject Escal2;
    public GameObject Escal3;
    public GameObject Escal4;
    public GameObject Escal5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Escal1.SetActive(false);
        Escal2.SetActive(false);
        Escal3.SetActive(false);
        Escal4.SetActive(false);
        Escal5.SetActive(false);
    }
}
