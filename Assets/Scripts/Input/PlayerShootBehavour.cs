using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehavour : MonoBehaviour
{
    [SerializeField]
    private GunBehavior _bulletEmitter;
    [SerializeField]
    private AudioSource _laserSound;
    // Update is called once per frame
    void Update()
    {
        //Checks to see if the player pressed the button to fire.
        if (Input.GetButtonDown("Fire1"))
        {
            //Calls the shoot function for the gun.
            _bulletEmitter.Shoot();
        }
    }
}
