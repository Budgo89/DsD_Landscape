using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RagdollAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Vector3 _impulse;
    private Rigidbody[] _rigidbodies;
    private Collider[] _colliders;

    private void Awake()
    {
        _rigidbodies = gameObject.GetComponentsInChildren<Rigidbody>();
        _colliders = gameObject.GetComponentsInChildren<Collider>();
    }

    private void Death()
    {
        SetState(false);
        _rigidbodies.First().AddForce(_impulse, ForceMode.Impulse);
    }

    private void SetState(bool isAvive)
    {
        foreach (var bodies in _rigidbodies)
        {
            bodies.isKinematic = !isAvive;
        }
        foreach (var collider in _colliders)
        {
            collider.enabled = !isAvive;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Death();
        }
    }
}
