using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailEscalier : MonoBehaviour
{

    public GameObject Escalier1;
    public GameObject Escalier2;
    public GameObject Escalier3;
    public GameObject Escalier4;
    public GameObject Escalier5;
    public GameObject Escalier6;
    public GameObject Escalier7;
    public GameObject Escalier8;
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
        Escalier1.SetActive(false);
        Escalier2.SetActive(false);
        Escalier3.SetActive(false);
        Escalier4.SetActive(false);
        Escalier5.SetActive(false);
        Escalier6.SetActive(false);
        Escalier7.SetActive(false);
        Escalier8.SetActive(false);
    }
}
