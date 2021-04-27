using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobDie : MonoBehaviour
{
    [SerializeField] public int _health;

    public void Hurt(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Invoke("Die",5);
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }



}
