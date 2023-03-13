using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infomation : MonoBehaviour
{
    public TurnManager TM;
    public NumbersAdvice NA;
    [SerializeField] TheAI AI;
    [SerializeField] TheAIEasy AIE;
    public GameObject info;
    [SerializeField] GameObject[] numbers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) 
        {
            info.SetActive(false);
        }
    }

    IEnumerator ActivateWait()
    {
        yield return null;
        info.SetActive(true);
        if(TM.offline == false && TM.easy == false) 
        {
            for (int i = 0; i <= 8; i++)
            {
                if (AI.summonable[i] == true) numbers[i].SetActive(true);
                else if (AI.summonable[i] == false) numbers[i].SetActive(false);
            }
        }
        else if (TM.easy)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (AIE.summonable[i] == true) numbers[i].SetActive(true);
                else if (AIE.summonable[i] == false) numbers[i].SetActive(false);
            }
        }
        else if (TM.offline && TM.PlayerTurn)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (NA.player2Summonable[i] == true) numbers[i].SetActive(true);
                else if (NA.player2Summonable[i] == false) numbers[i].SetActive(false);
            }
        }
        else if (TM.offline && TM.EnemyTurn)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (NA.playerSummonable[i] == true) numbers[i].SetActive(true);
                else if (NA.playerSummonable[i] == false) numbers[i].SetActive(false);
            }
        }
    }

    void OnMouseUp() 
    {
        StartCoroutine(ActivateWait());
    }
}
