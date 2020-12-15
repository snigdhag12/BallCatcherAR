using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public GameObject game;
    public GameObject walls;

    public void changeKinematic()
    {
        // Physics.gravity = new Vector3(0,-0.5f,0);
        foreach (Transform child in game.transform)
        {
            Rigidbody rb;
            rb = child.gameObject.GetComponent<Rigidbody>();
            rb.mass = 1;

        }
        foreach (Transform child in walls.transform)
        {
            Rigidbody rb;
            rb = child.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.isKinematic = false;

        }
        // walls.GetComponent<Rigidbody>().useGravity = true;

        
    }

    // void Start()
    // {
        
    //     StartCoroutine(wait30());
    // }

    // IEnumerator wait30()
    // {   this.gameObject.active = false;
    //     yield return new WaitForSeconds(5f);

    //     this.gameObject.active = true;
    // }
}