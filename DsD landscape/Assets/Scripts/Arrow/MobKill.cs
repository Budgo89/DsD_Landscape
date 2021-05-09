using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MobKill : MobDie
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _brute;
    [SerializeField] private TMP_Text _task;
    
    public void Hurt(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            StartCoroutine("DieRoutine");
            _animator.enabled = false;
            gameObject.GetComponent<MobTurel>().enabled = false;
            _brute.GetComponent<OpenOnionDialogue>().i = 3;
            _task.text = "Вернитесь к лесорубу";
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
