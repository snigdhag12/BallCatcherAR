using Mirror;
using UnityEngine;
using UnityEngine.Networking;

//Note: add script to player gameobject
//      when multiplayer game starts
//      turns off scripts off other players that are not you
//      why? so you dont control them

public class TurnOffRemotePlayer : NetworkBehaviour
{
    
    private void Start()
    {
        string id = string.Format("{0}", this.netId);
        Player scr = this.GetComponent<Player>();
        Debug.Log("ID = " + id);


        if (this.isLocalPlayer == true)
        {
            scr.enabled = true;
            scr.SetPlayerCaption(id);
            // Debug.Log(id);
            scr.playernum = id;
            Debug.Log("playernum = " + scr.playernum);
            // scr.SetTitle("MultiPlayer #" + id);
        }
        else
        {
            scr.SetPlayerCaption(id);
            scr.enabled = false;
            scr.playernum = id;
            Debug.Log("playernum = " + scr.playernum);           

        }

    }

    private void Update()
    {
        string id = string.Format("{0}", this.netId);
        Player scr = this.GetComponent<Player>();

        string score2 = (scr.score).ToString();
        if (this.isLocalPlayer == true)
        {
            scr.enabled = true;
            scr.SetPlayerCaption(id +" "+ score2);
            // scr.SetTitle("MultiPlayer #" + id);
            scr.playernum = id;
        }
        else
        {
            // scr.SetPlayerCaption(id);
            scr.enabled = false;
            scr.SetPlayerCaption(id +" "+ score2);
            // scr.SetTitle("MultiPlayer #" + id);
        }
    }
}
