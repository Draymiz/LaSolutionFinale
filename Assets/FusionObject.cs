using System.Collections.Generic;
using UnityEngine;

public class FusionObject : MonoBehaviour
{
    public List<GameObject> GameobjectToDestroy;
    public GameObject GameObjectToActivate;

    public void LaunchFusion()
    {
        Debug.Log("FUUUUUUUUUUSSSSION de " + name);

        foreach(GameObject go in GameobjectToDestroy)
        {
            Destroy(go);
        }
        GameObjectToActivate.SetActive(true);
        Destroy(gameObject);
    }
}