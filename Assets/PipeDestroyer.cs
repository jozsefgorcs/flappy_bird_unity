using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroyer : MonoBehaviour
{
    [SerializeField]
    private int xPosToDestroy;
 
    void Update()
    {
        if (transform.position.x < xPosToDestroy) {
            Destroy(gameObject);
        }
    }
}
