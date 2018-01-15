using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public int iUnlockCost;
    public bool bUnlocked;
    public GameManager gamemanager;
    public float timer;

    

    public GameObject coinlocation;

    public GameObject myCanvas;
    public SpriteRenderer mysprite;
    public Color a;

    public GameObject nextUpgrade;
    public GameObject pricetag;

    //public GameObject skyrim;
    //public GameObject skyrimLDR;
    //public GameObject skyrimSPEC;
    //public GameObject skyrimVR;
    //public GameObject skyrimSWITCH;

    [Header("Base passive rate")]
    public int iBaseDollarPerCycle;
    public float cycletimeInSeconds;

    public void Awake()
    {
        a = GetComponent<SpriteRenderer>().color;
    }

    public void Update()
    {
        if(bUnlocked)
        {
            a.a = 255;
            mysprite.color = a;
            
            myCanvas.SetActive(true);
            timer += Time.deltaTime;
            if(timer >= cycletimeInSeconds)
            {
                timer = 0;
                Reward();
            }
        }

        coinlocation.GetComponent<Image>().fillAmount += Time.deltaTime / cycletimeInSeconds;
    }

    public void Reward()
    {
        gamemanager.AddMoney(iBaseDollarPerCycle);
        GameObject coin = Instantiate(gamemanager.clickTodd.obj, coinlocation.transform.position, this.gameObject.transform.rotation);
        
        coin.GetComponent<Rigidbody2D>().AddForce(Vector2.left * Random.Range(-50, 50));
        coinlocation.GetComponent<Image>().fillAmount = 0;

        Destroy(coin, 5);
    }

    private void OnMouseEnter()
    {
        if (!bUnlocked)
        {
            pricetag.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        
        pricetag.SetActive(false);
        

        
    }

    private void OnMouseDown()
    {
        
        if (!bUnlocked && gamemanager.iBudget >= iUnlockCost)
        {
            coinlocation.GetComponent<Image>().fillAmount = 0;
            pricetag.SetActive(false);
            gamemanager.AddMoney(-iUnlockCost);
            if(nextUpgrade != null)
            {
                nextUpgrade.SetActive(true);
            }
            
            bUnlocked = true;
        }       
    }
}
