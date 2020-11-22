using System.Collections;
using System;

using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> GOs = new List<GameObject>();
    public Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();

    // Update is called once per frame
    void Update()
    {   
        // DateTime current = DateTime.Now; //Current TIME
        if (dict.Count >1)
        {
            DateTime Date1= dict["1"];
            DateTime Date2= dict["2"];
            // DateTime result = Ti
            // TimeSpan diff = Math.Abs(Date1-Date2);
            TimeSpan diff = Date1-Date2;
            double diff2 = Math.Abs(diff.TotalSeconds);
            // Debug.Log(Math.Abs(diff.TotalSeconds));
            Debug.Log(diff2);
            if (diff2<15)
            {
                Debug.Log("Destroy");
                Destroy(this.gameObject);
                Player scr1 = GOs[0].GetComponent<Player>();
                scr1.score++; scr1.score++; scr1.score++; scr1.score++;
                Player scr2 = GOs[1].GetComponent<Player>();
                scr2.score++; scr2.score++; scr2.score++; scr2.score++;
            }
        }


    }
    
    void OnCollisionEnter(Collision Other)
    {
        Debug.Log("Object Entered");
        DateTime my = DateTime.Now;
    
        // Debug.Log(Other.gameObject.ToString());
        if (Other.gameObject.ToString()=="Player(Clone) (UnityEngine.GameObject)")
        {   
            
            GOs.Add(Other.gameObject);
            Debug.Log("YES");
            Player scr = Other.gameObject.GetComponent<Player>();
            // Debug.Log(scr.playernum);
            
            dict.Add(scr.playernum,my);
            Debug.Log(dict.Count);

        }
        
    }
        void OnCollisionExit(Collision Other)
    {
        Debug.Log("Object Exited");
        // GOs.Remove(Other.gameObject); 
        // Debug.Log(Other.gameObject.ToString());

        if (Other.gameObject.ToString()=="Player(Clone) (UnityEngine.GameObject)")
        {   
            GOs.Remove(Other.gameObject); 
            Debug.Log("NO");
            Player scr = Other.gameObject.GetComponent<Player>();
            // Debug.Log(GOs.Count);
            dict.Remove(scr.playernum);
            Debug.Log(dict.Count);

        }
    }

}
