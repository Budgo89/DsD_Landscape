using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitMobKill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
            Destroy(gameObject);
        
        if (other.GetComponent<BoxCollider>())
            Destroy(gameObject);
        
        if (other.GetComponent<Terrain>())
            Destroy(gameObject);
    }
}
