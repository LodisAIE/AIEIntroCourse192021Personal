using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private GameObject _particleSystem;
    [SerializeField]
    private AudioSource _hitSound;
    [SerializeField]
    private AudioSource _explosionSound;
    [SerializeField]
    private ScreenShakeBehaviour _cameraShake;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    public void TakeDamage(float damageAmount)
    {
        _health -= damageAmount;

        if (_health <= 0)
        {
            isAlive = false;
        }
        //Play the hit sound effect after this object takes damage.
        _hitSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
        {
            Instantiate(_particleSystem, transform.position, new Quaternion());
            //Play the exlposion sound effect once this object dies.
            _explosionSound.Play();
            _cameraShake.ShakeCamera();
            Destroy(gameObject);
        }
    }
}
