using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] UIObj;

    public void ChangeUIShow(string Obj)
    {
        switch (Obj)
        {
            case "Milk":
                UIObj[0].SetActive(true);
                LoopSetFalse(0);
                break;
            case "ICE":
                UIObj[1].SetActive(true);
                LoopSetFalse(1);
                break;
            case "Water":
                UIObj[2].SetActive(true);
                LoopSetFalse(2);
                break;
            case "Sugar":
                UIObj[3].SetActive(true);
                LoopSetFalse(3);
                break;
            case "Bean":
                UIObj[4].SetActive(true);
                LoopSetFalse(4);
                break;
            case "Bee":
                UIObj[5].SetActive(true);
                LoopSetFalse(5);
                break;
        }
    }

    private void LoopSetFalse(int notLoop)
    {
        for(int i = 0;i < UIObj.Length;i++)
        {
            if(i !=  notLoop)
            {
               UIObj[i].SetActive(false);
            }
        }
    } 
}
