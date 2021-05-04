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
            DieRoutine();
        }
    }
    private IEnumerator DieRoutine()
    {
        yield return new WaitForSeconds(5);
        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
