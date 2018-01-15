using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

    public GameManager gameManager;
    public int iDialogueEntryNumber;
    public bool bTextToRead;
    public GameObject upgrades;
    public GameObject lastUpgrade;
    public Animator animBox;

    public GameObject sack;

    public Text dialogueText;
    

    public List<string> lines;

    public void ForceSkip()
    {
        iDialogueEntryNumber++;
    }

    public void Skip()
    {
        if(lines[iDialogueEntryNumber] != "")
        {
            iDialogueEntryNumber++;
        }
        



        /*

        if(true)
        {
            iDialogueEntryNumber++;
            print("Skip");
        }

        if(lines[iDialogueEntryNumber] == "" && lines[iDialogueEntryNumber +1] != "")
        {
            animBox.SetTrigger("pEntry");
        }

        if (lines[iDialogueEntryNumber] != "" && lines[iDialogueEntryNumber + 1] == "")
        {
            animBox.SetTrigger("pExit");
        }
        */

    }

    private void Update()
    {
        if (lines[iDialogueEntryNumber] != "")
        {
            bTextToRead = true;
            animBox.SetBool("bText", true);
            gameManager.animToddy.SetBool("bTalk", true);

        }
        else
        {
            animBox.SetBool("bText", false);
            gameManager.animToddy.SetBool("bTalk", false);
            bTextToRead = false;
        }




        dialogueText.text = lines[iDialogueEntryNumber];





        if(iDialogueEntryNumber == 12)
        {
            gameManager.textBudget.transform.parent.transform.gameObject.SetActive(true);
        }

        if(iDialogueEntryNumber == 16)
        {
            gameManager.animToddy.SetTrigger("pGetMoney");
            iDialogueEntryNumber++;
            
        }

        if(gameManager.iBudget == 500 && iDialogueEntryNumber == 13)
        {
            iDialogueEntryNumber = 14;
        }

        if(iDialogueEntryNumber == 19)
        {
            upgrades.SetActive(true);
        }

        if(lastUpgrade.GetComponent<Upgrades>().bUnlocked && iDialogueEntryNumber <= 20)
        {
            iDialogueEntryNumber = 21;
        }

        if(iDialogueEntryNumber >= 22)
        {
            sack.gameObject.SetActive(true);
        }
        if (iDialogueEntryNumber == 24)
        {
            Application.Quit();
            print("Close Game");
        }

    }

}
