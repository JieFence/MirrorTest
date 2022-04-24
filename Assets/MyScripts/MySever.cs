using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MySever : NetworkBehaviour
{
    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("The Sever has Opened!");
    }
 
    private void Update()
    {

    }  
}
