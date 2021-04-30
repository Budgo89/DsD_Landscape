using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHit : MonoBehaviour
{
    private int _damage=3;
    [SerializeField] private GameObject _light;

    public void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<MobKill>();
        
        if (enemy != null)
        {
            enemy.Hurt(_damage);
            gameObject.SetActive(false);
            Destroy(gameObject);
            _light.SetActive(true);
            Invoke("lightOff", 1f);
        }
    }
    private void lightOff()
    {
        _light.SetActive(false);
    }
}
