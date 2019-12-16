using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
  //  public FirstPersonController firstPersonController;

    public GameObject Curseur;
    public GameObject Panel;

    public bool leMenu;

    public float timePause;
    public float timePlay;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && leMenu == false)
        {
         //    firstPersonController.MouseLook.XSensitivity = 0f;
            Time.timeScale = timePause;
            Curseur.SetActive(false);
            Panel.SetActive(true);
            leMenu = true;
            return;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && leMenu == true)
        {
            Time.timeScale = timePlay;
            leMenu = false;
            Panel.SetActive(false);
            Curseur.SetActive(true);
        }
    }
}
