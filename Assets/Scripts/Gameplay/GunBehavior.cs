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
        //Grabs the tag of the game object the gun is attached to.
        _shooterName = transform.parent.tag;
    }

    /// <summary>
    /// Called when the player wants to spawn a bullet,
    /// </summary>
    public void Shoot()
    {
        //Spawns a clone of the bullet in the scene, and stores it in the newBullet variable.
        GameObject newBullet = Instantiate(_bullet, transform.position, new Quaternion());
        //Grabs the bullet script attached to the bullet.
        BulletBehavior bulletScript = newBullet.GetComponent<BulletBehavior>();
        //Calls the bullet's fire function; passing in the guns facing scaled by bullet speed for the direction.
        //The tag of the parent of the gun is passed in as the second argument.
        bulletScript.Fire(transform.forward * _bulletSpeed, _shooterName);
    }
}
