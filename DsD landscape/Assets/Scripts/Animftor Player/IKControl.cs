using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControl : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    RaycastHit hit;
    void Start () 
    {
        _animator = GetComponent<Animator>();
    }
    private void OnAnimatorIK(int layerIndex)
    {
        var _rightHand = _animator.GetBoneTransform(HumanBodyBones.RightShoulder);
        var _leftHand = _animator.GetBoneTransform(HumanBodyBones.LeftShoulder);
        
        if (Physics.Raycast(_rightHand.position, gameObject.transform.right, out hit, 0.9f))
        {
            // Debug.DrawLine(_rightHand.position, hit.point);
            Right();
        }
        if (Physics.Raycast(_leftHand.position, -gameObject.transform.right, out hit, 0.9f))
        {
            // Debug.DrawLine(_leftHand.position, hit.point, Color.red);
            Left();
        }
        if (Physics.Raycast(_rightHand.position,gameObject.transform.forward, out hit, 1f))
        {
            // Debug.DrawLine(_rightHand.position, hit.point, Color.green);
            Right();
        }
        if (Physics.Raycast(_leftHand.position,gameObject.transform.forward, out hit, 1f))
        {
            // Debug.DrawLine(_leftHand.position, hit.point, Color.green);
            Left();
        }

        var _rightFootWeight= _animator.GetFloat("RightLeglIKWeight");
        var _lefttFootWeight =  _animator.GetFloat("LeftLeglIKWeight");
        var _leftFoot = _animator.GetBoneTransform(HumanBodyBones.LeftFoot);
        var _righFoot = _animator.GetBoneTransform(HumanBodyBones.RightFoot);
        if (Physics.Raycast(_leftFoot.position, Vector3.back, out hit,0.1f))
        {
            _animator.SetIKPosition(AvatarIKGoal.LeftFoot, hit.point);
            _animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, _lefttFootWeight);
        }
        if (Physics.Raycast(_righFoot.position, Vector3.down, out hit,0.2f))
        {
            _animator.SetIKPosition(AvatarIKGoal.RightFoot, hit.point);
            _animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, _lefttFootWeight);
        }
        
    }
    private void Right()
    {
        _animator.SetIKPosition(AvatarIKGoal.RightHand, hit.point);
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
    }

    private void Left()
    {
        _animator.SetIKPosition(AvatarIKGoal.LeftHand, hit.point);
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
    }
}
