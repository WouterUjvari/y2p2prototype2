using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //todd
    public Animator animToddy;

    //clickerstuff
    public int iHowardPower;
    public int iMetaCriticHealth;
    public int iBudget;

    




    private void Start()
    {
        
    }


    public void Pop()
    {
        animToddy.SetTrigger("Pop");

    }




}
