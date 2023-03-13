using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TheAIEasy : MonoBehaviour
{
    [SerializeField] NumbersAdvice NA;
    public TurnManager TM;

    public GameObject[] pone;
    [SerializeField] Vector3 startPos;
    public bool[] summonable;

    int Pattern;
    int PatternS;
    bool randomFin = false;

    public GameObject poneE;

    void Start()
    {
        SummonablePrepare();
    }

    void Update()
    {

    }

    void SummonablePrepare()
    {
        Debug.Log("SummonablePrepare");
        for (int i = 0; i <= 8; i++)
        {
            summonable[i] = true;
        }
        PatternS = Random.Range(1, 10);
    }

    public void AIAnalyze()
    {
        Debug.Log("AIAnalyze");
        for (int i = 0; i >= 18; i++)
        {
            pone[i] = null;
        }
        pone[0] = GameObject.FindWithTag("SA2P");
        pone[1] = GameObject.FindWithTag("SB2P");
        pone[2] = GameObject.FindWithTag("SC2P");
        pone[3] = GameObject.FindWithTag("SA3P");
        pone[4] = GameObject.FindWithTag("SB3P");
        pone[5] = GameObject.FindWithTag("SC3P");
        pone[6] = GameObject.FindWithTag("SA4P");
        pone[7] = GameObject.FindWithTag("SB4P");
        pone[8] = GameObject.FindWithTag("SC4P");
        pone[9] = GameObject.FindWithTag("SA1E");
        pone[10] = GameObject.FindWithTag("SB1E");
        pone[11] = GameObject.FindWithTag("SC1E");
        pone[12] = GameObject.FindWithTag("SA2E");
        pone[13] = GameObject.FindWithTag("SB2E");
        pone[14] = GameObject.FindWithTag("SC2E");
        pone[15] = GameObject.FindWithTag("SA3E");
        pone[16] = GameObject.FindWithTag("SB3E");
        pone[17] = GameObject.FindWithTag("SC3E");
        randomFin = false;
        if (NA.enemyLife > 0) Lethal();
    }

    void Lethal()
    {
        Debug.Log("Lethal");
        if (NA.playerLife <= 5 && (pone[15] != null || pone[16] != null || pone[17] != null))
        {
            if (pone[15] != null && (pone[6] == null || pone[15].GetComponent<TheNumber>().number > pone[6].GetComponent<TheNumber>().number)) GoS(pone[15]);
            else if (pone[15] != null && (pone[7] == null || pone[15].GetComponent<TheNumber>().number > pone[7].GetComponent<TheNumber>().number)) GoL(pone[15]);
            else if (pone[16] != null && (pone[6] == null || pone[16].GetComponent<TheNumber>().number > pone[6].GetComponent<TheNumber>().number)) GoR(pone[16]);
            else if (pone[16] != null && (pone[7] == null || pone[16].GetComponent<TheNumber>().number > pone[7].GetComponent<TheNumber>().number)) GoS(pone[16]);
            else if (pone[16] != null && (pone[8] == null || pone[16].GetComponent<TheNumber>().number > pone[8].GetComponent<TheNumber>().number)) GoL(pone[16]);
            else if (pone[17] != null && (pone[7] == null || pone[17].GetComponent<TheNumber>().number > pone[7].GetComponent<TheNumber>().number)) GoR(pone[17]);
            else if (pone[17] != null && (pone[8] == null || pone[17].GetComponent<TheNumber>().number > pone[8].GetComponent<TheNumber>().number)) GoS(pone[17]);
            else Closer();
        }
        else Closer();
    }

    void Closer()
    {
        Debug.Log("Closer");
        if (pone[9] != null || pone[10] != null || pone[11] != null || pone[12] != null || pone[13] != null || pone[14] != null || pone[15] != null || pone[16] != null || pone[17] != null)
        {
            for (int i = 17; i >= 9; i -= 1)
            {
                if (pone[i] != null)
                {
                    if (i == 10 || i == 13 || i == 16)
                    {
                        if (pone[i - 9] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 9].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                        else if (pone[i - 10] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 10].GetComponent<TheNumber>().number)
                        {
                            GoR(pone[i]);
                            break;
                        }
                        else if (pone[i - 8] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 8].GetComponent<TheNumber>().number)
                        {
                            GoL(pone[i]);
                            break;
                        }
                        //—v’¼‚µ
                        else if (pone[i - 9] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 9].GetComponent<TheNumber>().number)
                        {
                            GoL(pone[i]);
                            break;
                        }
                        else if (pone[i - 10] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 10].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                        else if (pone[i - 8] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 8].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                    }
                    else if (i == 9 || i == 12 || i == 15)
                    {
                        if (pone[i - 8] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 8].GetComponent<TheNumber>().number)
                        {
                            GoL(pone[i]);
                            break;
                        }
                        else if (pone[i - 9] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 9].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                        else if (pone[i - 8] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 8].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                        else if (pone[i - 9] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 9].GetComponent<TheNumber>().number)
                        {
                            GoL(pone[i]);
                            break;
                        }
                    }
                    else if (i == 11 || i == 14 || i == 17)
                    {
                        if (pone[i - 10] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 10].GetComponent<TheNumber>().number)
                        {
                            GoR(pone[i]);
                            break;
                        }
                        else if (pone[i - 9] != null && pone[i].GetComponent<TheNumber>().number >= pone[i - 9].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                        else if (pone[i - 10] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 10].GetComponent<TheNumber>().number)
                        {
                            GoS(pone[i]);
                            break;
                        }
                        else if (pone[i - 9] != null && pone[i].GetComponent<TheNumber>().number < pone[i - 9].GetComponent<TheNumber>().number)
                        {
                            GoR(pone[i]);
                            break;
                        }
                    }
                }
                if (i == 9) RGo();
            }
        }
        else RGo();
    }

    void RGo()
    {
        Debug.Log("RGo");
        if (pone[9] != null || pone[10] != null || pone[11] != null || pone[12] != null || pone[13] != null || pone[14] != null || pone[15] != null || pone[16] != null || pone[17] != null)
        {
            for (int i = 17; i >= 8; i -= 1)
            {
                if (pone[i] != null && (i == 11 || i == 14 || i == 17))
                {
                    Pattern = Random.Range(0, 2);
                    if (Pattern == 0)
                    {
                        GoS(pone[i]);
                        break;
                    }
                    else if (Pattern == 1)
                    {
                        GoR(pone[i]);
                        break;
                    }
                }
                else if (pone[i] != null && (i == 10 || i == 13 || i == 16))
                {
                    Pattern = Random.Range(0, 3);
                    if (Pattern == 0)
                    {
                        GoS(pone[i]);
                        break;
                    }
                    else if (Pattern == 1)
                    {
                        GoL(pone[i]);
                        break;
                    }
                    else if (Pattern == 2)
                    {
                        GoR(pone[i]);
                        break;
                    }
                }
                else if (pone[i] != null && (i == 9 || i == 12 || i == 15))
                {
                    Pattern = Random.Range(0, 2);
                    if (Pattern == 0)
                    {
                        GoS(pone[i]);
                        break;
                    }
                    else if (Pattern == 1)
                    {
                        GoL(pone[i]);
                        break;
                    }
                }
            }
        }
        else
        {
            RSum();
        }
    }

    void RSum()
    {
        Debug.Log("RSum");
        for (int i = NA.enemyLife - 2; i >= -1; i = i - 1)
        {
            if (i <= 8 && i >= 0 && summonable[i] == true && i < NA.enemyLife)
            {
                while (randomFin == false)
                {
                    PatternS = Random.Range(1, NA.enemyLife - 2);
                    if (PatternS <= 9 && summonable[PatternS - 1] == true)
                    {
                        Pattern = Random.Range(9, 12);
                        Summo(PatternS, Pattern);
                        randomFin = true;
                        break;
                    }
                }
            }
            else if (i == 0)
            {
                while (randomFin == false)
                {
                    PatternS = Random.Range(1, 10);
                    if (summonable[PatternS - 1] == true)
                    {
                        Pattern = Random.Range(9, 12);
                        Summo(PatternS, Pattern);
                        randomFin = true;
                        break;
                    }
                }
            }
            else if (i == -1)
            {
                while (randomFin == false)
                {
                    PatternS = Random.Range(1, 10);
                    if (summonable[PatternS - 1] == true)
                    {
                        Pattern = Random.Range(9, 12);
                        Summo(PatternS, Pattern);
                        randomFin = true;
                        break;
                    }
                }
            }
        }
    }

    void GoL(GameObject go)
    {
        Debug.Log("GoL");
        TM.EnemyTurn = false;
        startPos = go.transform.position;
        go.transform.DORotate(new Vector3(-360f, 0, 0), 0.5f, RotateMode.FastBeyond360);
        go.transform.DOMove(new Vector3(startPos.x, 5f, startPos.z), 0.5f).SetEase(Ease.InOutQuad);
        go.transform.DOMove(new Vector3(startPos.x + 4, 1.1f, startPos.z - 4.6f), 0.5f).SetEase(Ease.InOutQuad).SetDelay(0.5f);
        DOVirtual.DelayedCall(2.2f, () => TM.TurnTurnP());
    }

    void GoS(GameObject go)
    {
        Debug.Log("GoS");
        TM.EnemyTurn = false;
        startPos = go.transform.position;
        go.transform.DORotate(new Vector3(-360f, 0, 0), 0.5f, RotateMode.FastBeyond360);
        go.transform.DOMove(new Vector3(startPos.x, 5f, startPos.z), 0.5f).SetEase(Ease.InOutQuad);
        go.transform.DOMove(new Vector3(startPos.x, 1.1f, startPos.z - 4.6f), 0.5f).SetEase(Ease.InOutQuad).SetDelay(0.5f);
        DOVirtual.DelayedCall(2.2f, () => TM.TurnTurnP());
    }

    void GoR(GameObject go)
    {
        Debug.Log("GoR");
        TM.EnemyTurn = false;
        startPos = go.transform.position;
        go.transform.DORotate(new Vector3(-360f, 0, 0), 0.5f, RotateMode.FastBeyond360);
        go.transform.DOMove(new Vector3(startPos.x, 5f, startPos.z), 0.5f).SetEase(Ease.InOutQuad);
        go.transform.DOMove(new Vector3(startPos.x - 4, 1.1f, startPos.z - 4.6f), 0.5f).SetEase(Ease.InOutQuad).SetDelay(0.5f);
        DOVirtual.DelayedCall(2.2f, () => TM.TurnTurnP());
    }

    void Summo(int sumN, int pos)
    {
        Debug.Log("Summo");
        NA.summonNumber = sumN;
        summonable[sumN - 1] = false;
        if (pos == 9) Instantiate(poneE, new Vector3(-4, 16.12f, 6.9f), Quaternion.identity);
        else if (pos == 10) Instantiate(poneE, new Vector3(0, 16.12f, 6.9f), Quaternion.identity);
        else if (pos == 11) Instantiate(poneE, new Vector3(4, 16.12f, 6.9f), Quaternion.identity);
        DOVirtual.DelayedCall(1.5f, () => TM.TurnTurnP());
    }
}
