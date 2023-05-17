using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Collectable"))
        {
            other.gameObject.transform.position = transform.position - Vector3.right; //add collected money to the "list"

            Destroy(gameObject.GetComponent<Collect>()); //destroy collect script from "collecter" item.

            other.gameObject.AddComponent<Collect>(); //add collect script to the last item of the list.
            other.GetComponent<BoxCollider>().isTrigger = false; //to prevent issues
            other.gameObject.tag = "Collected"; //change tag of the last item as collected so that we can collect again. Collectable items CAN NOT collect Collectable items!.

            other.gameObject.AddComponent<NodeMovement>(); //to add lerped movement
            other.gameObject.GetComponent<NodeMovement>().connectedNode = transform;

        }
    }
}
