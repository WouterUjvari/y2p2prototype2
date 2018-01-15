using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickTodd : MonoBehaviour {

    public GameManager gameManager;
    public bool canbeclicked;
    public GameObject obj;

    public void OnMouseDown()
    {
        if(canbeclicked)
        {
            gameManager.AddMoney(10);
            gameManager.animToddy.SetTrigger("pPop");
            

            if (gameManager.dialogue.iDialogueEntryNumber <= 3)
            {
                gameManager.dialogue.iDialogueEntryNumber = 4;
            }
            else
            {
                GameObject coin = Instantiate(obj, this.gameObject.transform.position, this.gameObject.transform.rotation);
                coin.GetComponent<Rigidbody2D>().AddForce(Vector2.left * Random.Range(-100, 300) + Vector2.up * Random.Range(400, 800));
                Destroy(coin, 5);
            }
        }
    }
}
