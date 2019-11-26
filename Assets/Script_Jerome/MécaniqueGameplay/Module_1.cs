using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }



    // Joueur positionner sur un box collider détectant si le joueur est dans la zone et si le raycast du joueur la camera occlusing et sur le box collider placer  

    // Prend un objet https://www.youtube.com/watch?v=Xv-c3-IOnM0 ou https://www.youtube.com/watch?v=IEV64CLZra8

    //  https://answers.unity.com/questions/8003/how-can-i-know-if-a-gameobject-is-seen-by-a-partic.html  Camera.isvisible
}
