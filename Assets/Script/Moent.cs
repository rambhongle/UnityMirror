using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class Moent : NetworkBehaviour
{
    
    void PlayerMOM()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(h, v, 0);
        transform.position = transform.position + mov;
    }

    private void Update()
    {
        PlayerMOM();
    }
}
