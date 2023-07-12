using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterController : MonoBehaviour
{
    public Action<int> done;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(done != null)
            {
                done.Invoke(1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (done != null)
            {
                done.Invoke(2);
            }
        }
    }
}
