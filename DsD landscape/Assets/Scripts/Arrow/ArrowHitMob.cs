using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitMob : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    
    private void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<MyEnemy>();

        if (enemy != null)
        {
            enemy.Hurt(_damage);
            enemy.Vignettes(0.5f);
            gameObject.SetActive(false);

        }
    }

}
