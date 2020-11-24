using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{

    // this sample script demonstrates that the enemy's line of sight can be changed simply by treating it as a child object which is moved when the parent's transform is moved
    // in this case we flip the enemies on the x-axis every three seconds so they look the other way
  
    public void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, 1);

    }
}
