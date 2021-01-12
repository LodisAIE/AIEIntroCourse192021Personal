using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField]
    private float _despawnTime;
    [SerializeField]
    private float _damage;

    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        HealthBehavior otherHealth = other.GetComponent<HealthBehavior>();

        if (otherHealth == null)
        {
            Destroy(gameObject);
        }

        else
        {
            otherHealth.TakeDamage(_damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
