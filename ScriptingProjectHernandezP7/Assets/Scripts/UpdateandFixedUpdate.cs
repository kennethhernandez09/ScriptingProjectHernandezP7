using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateandFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
