using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sack : MonoBehaviour {

    public Canvas ui;

    Quaternion rotation;
    void Awake()
    {
        //ui.transform.rotation = transform.rotation;
    }
    void LateUpdate()
    {
        ui.transform.rotation = Quaternion.identity;
    }
}
