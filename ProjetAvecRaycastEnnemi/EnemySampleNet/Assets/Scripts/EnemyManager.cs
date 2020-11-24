using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

    
    // this is used to flip the enemies on the x-axis every 3 seconds to demonstrate changing their field of view
    
    [SerializeField]
    EnemyBehaviour[] enemies;


    
    float flipDelay = 3.0f;
    float nextFlip;
	// Use this for initialization
	void Start () {
        nextFlip = Time.time + flipDelay;
	}
	
	// Update is called once per frame
	void Update () {
       if(Time.time >= nextFlip)
       {
           FlipEnemies();
           nextFlip = Time.time + flipDelay;
       }

	}

    void FlipEnemies()
    {
        foreach(EnemyBehaviour enemy in enemies)
        {
            enemy.Flip();
        }

    }

}
