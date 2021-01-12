using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;

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
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
        {
            Destroy(gameObject);
        }
    }
}
