using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorBrute : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _target;
    private float _distance;
    void Start () 
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (_target != null)
        {
            _distance = Vector3.Distance(_target.transform.position, transform.position);
            if (_distance <= 4)
            {
                _animator.SetLookAtPosition(_target.GetComponent<Animator>().GetBoneTransform(HumanBodyBones.Head).position);
                _animator.SetLookAtWeight(1);
            }
        }

    }
}
