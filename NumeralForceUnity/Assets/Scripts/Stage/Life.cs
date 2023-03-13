using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    public int LPnumber;
    public int LEnumber;
    public TextMeshProUGUI LPtx;
    public TextMeshProUGUI LEtx;
    public NumbersAdvice NA;
    [SerializeField] TurnManager TM;

    // Start is called before the first frame update
    void Start()
    {
        NA = GameObject.Find("GrandAdvisor").GetComponent<NumbersAdvice>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TM.offline) 
        {
            if (TM.PlayerTurn) 
            {
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
                LPtx.transform.localRotation = Quaternion.Euler(0, 0, 0);
                LEtx.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else if (TM.EnemyTurn)
            {
                this.transform.localRotation = Quaternion.Euler(0, 0, 180);
                LPtx.transform.localRotation = Quaternion.Euler(0, 0, 180);
                LEtx.transform.localRotation = Quaternion.Euler(0, 0, 180);
            }
            LPnumber = NA.playerLife;
            LEnumber = NA.enemyLife;
            LPtx.text = LPnumber.ToString();
            LEtx.text = LEnumber.ToString();
        }
        else 
        {
            LPnumber = NA.playerLife;
            LEnumber = NA.enemyLife;
            LPtx.text = LPnumber.ToString();
            LEtx.text = LEnumber.ToString();
        }
    }
}
