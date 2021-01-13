using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private float _bulletSpeed;
    private string _shooterName;

    private void Start()
    {
        _shooterName = transform.parent.tag;
    }

    public void Shoot()
    {
        GameObject newBullet = Instantiate(_bullet, transform.position, new Quaternion());
        BulletBehavior bulletScript = newBullet.GetComponent<BulletBehavior>();
        bulletScript.Fire(transform.forward * _bulletSpeed, _shooterName);
    }
}
