using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script controls the trampoline & how it adds force to the things that collide w/ it.
public class TrampolineBounce : MonoBehaviour
{
    public float bounceForce = 10f;
    public PhysicMaterial bounceMaterial;

    // Start is called before the first frame update
    void Start()
    {
      //Assign the bounce force to the trampoline collider.
      Collider trampolineCollider = GetComponent<Collider>();   //Gets the collider (box collider) of the trampoline & assigns it to 'trampolineCollider' variable
      trampolineCollider.material = bounceMaterial; //Assign the collider of the trampoline to the physicMaterial (bounceMaterial)
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube")) //1.If the trampoline collides w/ a prefab (gameObj) tagged 'Cube'
        {
          Rigidbody prefabRigidbody = collision.gameObject.GetComponent<Rigidbody>(); //2.get the Rigidbody of the gameObject (w/ 'Cube' tag) whose collider the trampoline is colliding w/ & assign it to 'prefabRigidbody' rigidbody
         
            if (prefabRigidbody != null) //3.Make sure the rigidbody of that prefab exists
            {
              prefabRigidbody.AddForce(Vector2.up * bounceForce, ForceMode.Impulse); //4.Then add a [upward] force to the rigidbody of the prefab
            }
        
        }
    
    }
}
