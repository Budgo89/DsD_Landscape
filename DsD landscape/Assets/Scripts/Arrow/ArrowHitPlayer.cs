using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitPlayer : MonoBehaviour
{
    private int _damage = 3;

    public void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<MobKill>();
        if (enemy != null)
        {
            enemy.Hurt(_damage);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
