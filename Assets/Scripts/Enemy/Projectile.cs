using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Projectile : MonoBehaviour
{
    //Like Fireball
    private Rigidbody _rb;

    private void Awake() => _rb = GetComponent<Rigidbody>();
    public void Launch(float movementSpeed) => _rb.AddForce(transform.forward * movementSpeed, ForceMode.Impulse);
    public class Factory : PlaceholderFactory<Projectile> { }
}
