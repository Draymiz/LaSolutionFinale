using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jouer : MonoBehaviour
{
    public void Jouable()
    {
        SceneManager.LoadScene("Bureau");
    }

}
