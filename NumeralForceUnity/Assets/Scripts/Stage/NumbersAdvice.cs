using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumbersAdvice : MonoBehaviour
{
    public int summonNumber;
    public int playerLife;
    public int enemyLife;

    [SerializeField] bool finished;

    public bool[] playerSummonable;
    public bool[] player2Summonable;

    public TurnManager TM;

    [SerializeField] bool tutrial;

    // Start is called before the first frame update
    void Start()
    {
        playerLife = 20;
        enemyLife = 20;
        if (tutrial) enemyLife = 10;

        for (int i = 0; i <= 8; i++)
        {
            playerSummonable[i] = true;
            player2Summonable[i] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLife <= 0) 
        {
            playerLife = 0;
            TM.PlayerTurn = false;
            TM.EnemyTurn = false;
            if (finished == false) 
            {
                DOVirtual.DelayedCall(2, () => TM.YouLose());
                finished = true;
            }
        }
        else if (enemyLife <= 0)
        {
            enemyLife = 0;
            TM.PlayerTurn = false;
            TM.EnemyTurn = false;
            if (finished == false)
            {
                DOVirtual.DelayedCall(2, () => TM.YouWin());
                finished = true;
            }
        }
    }
}
