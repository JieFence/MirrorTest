using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isLocalPlayer&&Input.GetKeyDown(KeyCode.C))
        {

        CallSever();    
        }
    }
    [Command]
    void CallSever()
    {
        Debug.Log("张三呼叫总部！");
        ReplyClient();
    }
    [TargetRpc]
    void ReplyClient()
    {
        Debug.Log("I have Copied,what Happened?");
    }   
}
