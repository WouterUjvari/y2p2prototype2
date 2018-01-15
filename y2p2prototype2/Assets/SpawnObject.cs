using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameManager gameManager;

    public Transform moneypos;

    public void SpawnMoney(GameObject obj)
    {
        GameObject sack = Instantiate(obj, moneypos.position, moneypos.rotation);
        sack.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 500 + Vector2.up * 200);

        
    }
}
