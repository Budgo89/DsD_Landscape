using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitKill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MobKill>())
            Destroy(gameObject);

        if (other.GetComponent<BoxCollider>())
            Destroy(gameObject);
        if (other.GetComponent<Terrain>())
            Destroy(gameObject);
    }
}
