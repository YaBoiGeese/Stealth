using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public Animator anim;
    public Rigidbody Object;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

            anim.Play("Slider Test Animation");

            anim.SetTrigger("Active");
        }
    }
        void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

        





    
}

