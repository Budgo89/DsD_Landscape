using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitMob : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<MyEnemy>();
        if (enemy != null)
        {
            enemy.Hurt(_damage);
            gameObject.SetActive(false);
        }
    }
}
