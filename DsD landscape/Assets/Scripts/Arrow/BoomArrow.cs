using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomArrow : MonoBehaviour
{
    [SerializeField] private Rigidbody _arrow;
    [SerializeField] private float _speed = 25;
    [SerializeField] private Transform _arrowSpavner;
    private Animator _anim;

    public void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _anim.SetTrigger("DrawArrow");
            StartCoroutine("DrawTaim");

        }
    }

    private IEnumerator DrawTaim()
    {
        yield return new WaitForSeconds(1);
        Draw();
    }

    private void Draw()
    {
        Rigidbody position = Instantiate(_arrow, _arrowSpavner.position, _arrowSpavner.rotation);
        position.velocity = transform.forward * _speed;
    }
}
