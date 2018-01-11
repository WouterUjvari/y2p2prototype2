using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour {

    public GameObject obj;
    
    public void DestroyThisBitch()
    {
        Destroy(obj);
    }
}
