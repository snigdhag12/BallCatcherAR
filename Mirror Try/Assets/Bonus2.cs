using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus2 : MonoBehaviour
{
    public GameObject game;

    void Start()
    {
        
        StartCoroutine(wait30());
    }

    IEnumerator wait30()
    {   game.gameObject.active = false;
        yield return new WaitForSeconds(5f);

        game.gameObject.active = true;
    }
}