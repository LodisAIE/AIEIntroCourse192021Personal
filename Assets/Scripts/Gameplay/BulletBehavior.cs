using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField]
    private float _despawnTime;
    [SerializeField]
    private float _damage;
    private Rigidbody _rigidbody;
    private string owner;


    private void Awake()
    {
        //Grabs the rigid body component attached to the bullet.
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Deletes the bullet after the given amount of time has passed.
        Destroy(gameObject, _despawnTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Checks to see if the tag of the object that the bullet collided with is the same as its owner.
        if (other.tag == owner)
        {
            //If the tag is the same as the owner name leave the function.
            return;
        }

        //Tries to find the health script on the game object it collided with.
        HealthBehavior otherHealth = other.GetComponent<HealthBehavior>();

        /// If the GetComponent function cannot find a health script on the object,
        /// it will set the variable we created to be null. If we check if the variable is not null,
        /// we'll be sure that our variable actually has a value in it before using it.
        if (otherHealth != null)
        {
            ///Calls the TakeDamage function for the object the bullet collided with. 
            ///Putting the bullets damage value in parenthesis tells the object to use
            ///the bullets damage amount to decrease the health.
            otherHealth.TakeDamage(_damage);
        }

        //Deletes the bullet once it has collided with an object.
        Destroy(gameObject);
    }

    /// <summary>
    /// Called whenever a bullet is going to be fired. Applies a force to the 
    /// gameObject using the velocity given.
    /// </summary>
    public void Fire(Vector3 force, string shooterTag)
    {
        //Sets the owner of this bullet to be the tag passed in
        owner = shooterTag;
        //Uses the attached rigid body to add an impulse force to the bullet.
        _rigidbody.AddForce(force, ForceMode.Impulse);
    }
}
