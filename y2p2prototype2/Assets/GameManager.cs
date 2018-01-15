using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //todd
    public Animator animToddy;

    //clickerstuff
    public int iHowardPower;
    public int iMetaCriticHealth;
    public int iBudget;

    //ui
    public Text textBudget;
    //public bool textBudgetEnabled;

    //dialogue
    public Dialogue dialogue;
    public ClickTodd clickTodd;

            
    




    private void Start()
    {
        
    }

    public void DialogueForceSkip()
    {
        dialogue.ForceSkip();
    }


    public void Update()
    {
        if(Input.GetKey("e"))
        {
            Time.timeScale = 10;
        }
        else
        {
            Time.timeScale = 1;
        }

        textBudget.text = iBudget.ToString();

        if(dialogue.bTextToRead)
        {
            clickTodd.canbeclicked = false;
        }
        else
        {
            clickTodd.canbeclicked = true;
        }
        
        





    }



    public void AddMoney(int amount)
    {
        iBudget += amount;
        //textBudget.transform.parent.transform.gameObject.GetComponent<Animator>().SetTrigger("pPop");
        textBudget.transform.parent.GetComponent<Animator>().SetTrigger("pPop");
        
    }




}
