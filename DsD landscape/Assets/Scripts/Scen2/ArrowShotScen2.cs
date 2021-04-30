using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShotScen2 : MonoBehaviour
{
    [SerializeField] private Rigidbody projectile;
    [SerializeField] private float speed = 4;
    [SerializeField] private Transform _arrowSpavner;
    [SerializeField] private GameObject _light;
    private void Draw()
    {
        Rigidbody position = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
        position.velocity = transform.forward * speed;
    }

    private void lightOff()
    {
        _light.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Draw();
            _light.SetActive(true);
        }
        Invoke("lightOff", 1f);
    }
}
