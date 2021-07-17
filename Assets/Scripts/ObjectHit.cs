using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) 
   {
        //When colliders touches
        //When the collision event take place
        //other means who collided
        if(other.gameObject.tag == "Player")//it needs to be exactly the same as your tag
        {
            Debug.Log("Bumped into the wall");
            GetComponent<MeshRenderer>().material.color = Color.green;
            // Get component is used to access to the components of what u write
            gameObject.tag = "Hit";
        }
        


   }
}
