using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTurel : MonoBehaviour
{
    [SerializeField] private Transform _player;
    // радиус стрельбы
    [SerializeField] private float _radius;
    private float _distance;

    [SerializeField] private Rigidbody projectile;
    //скорость фаербола
    [SerializeField] private float speedArrow = 30;
    //зона появления фаербола
    [SerializeField] private Transform _arrowSpavner;
    [SerializeField] private float _reloadTimer = 5f; //задержка между выстрелами, изменяемое значение
    private float reloadTimer;
    private Animator _anim;
    void Start()
    {
        reloadTimer = _reloadTimer;
        _anim = GetComponent<Animator>();

    }

    void Update()
    {
        if (_player != null)
        {
            _distance = Vector3.Distance(_player.position, transform.position);
            if (_distance <= _radius)
            {
                var relativePos = _player.position - transform.position;
                var rotation = Quaternion.LookRotation(relativePos);
                transform.rotation = rotation;
                if (reloadTimer > 0) reloadTimer -= Time.deltaTime; //если таймер перезарядки больше нуля - отнимаем его
                if (reloadTimer < 0)
                {
                    reloadTimer = _reloadTimer;
                    _anim.SetBool("Damag", true);
                    StartCoroutine("HinrOffTaim");
                }
            }
        }
    }
    private IEnumerator HinrOffTaim()
    {
        yield return new WaitForSeconds(1);
        DamagArrow();
    }
    private void DamagArrow()
    {
        if (_distance < _radius)
        {
            Rigidbody arrow = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            arrow.velocity = transform.forward * speedArrow;
        }
    }
    
}
