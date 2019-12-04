using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchangeCam : MonoBehaviour
{
    public Transform CameraJoueur;
    public Transform CamRecepteur;

    Vector3 PosDeBase;

    private void Update()
    {
        Pos();
        Debug.Log(PosDeBase);
    }
    public void Pos()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            CameraJoueur.transform.position = CamRecepteur.transform.position;
            CamRecepteur.transform.position = CameraJoueur.transform.position;
            
      
            Debug.Log(PosDeBase);
        }

        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            // Dernière pos de PosDeBase
            PosDeBase = CamRecepteur.transform.position;

        }
    }
}
