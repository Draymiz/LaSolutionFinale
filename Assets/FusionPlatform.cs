using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusionPlatform : MonoBehaviour
{
    public Camera camera;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) {
            FusionObject fusionObject = FusionRaycast(other.transform);
            fusionObject?.LaunchFusion();
        }
    }

    private FusionObject FusionRaycast(Transform playerTransform)
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            Transform objectHit = hit.transform;

            Debug.DrawRay(playerTransform.position, playerTransform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Did Hit");
            FusionObject fusionObject = hit.transform.GetComponent<FusionObject>();
            if (fusionObject != null)
                return fusionObject;
        }
        else
        {
            Debug.DrawRay(playerTransform.position, playerTransform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
        return null;
    }

}

