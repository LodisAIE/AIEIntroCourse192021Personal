using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private GunBehavior _gun;
    [SerializeField]
    private float _shotDelay;

    // Start is called before the first frame update
    void Start()
    {
        //Starts shooting when the enemy is placed in the scene.
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        //Loops while the enemy hasn't been destroyed.
        while (gameObject != null)
        {
            //Pauses the function dor the given amount of seconds.
            yield return new WaitForSeconds(_shotDelay);
            //Shoots the enmey's gun.
            _gun.Shoot();
        }
    }
}
