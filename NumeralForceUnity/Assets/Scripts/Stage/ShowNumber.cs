using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowNumber : MonoBehaviour
{

    [SerializeField]
    [Header("引数・数字UIオブジェクト")]
    public GameObject[] N1;

    public NumbersAdvice NA;
    [SerializeField] TurnManager TM;

    [SerializeField] bool tutrial;
    [SerializeField] TutrialStageCount tsc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i <= 8; i++)
            {
                N1[i].SetActive(false);
            }
        }
    }

    IEnumerator ActivateWait() 
    {
        yield return null;
        if (tutrial == false || tutrial && tsc.count != 17) 
        {
            if (TM.PlayerTurn) 
            {
                for (int i = 0; i <= 8; i++)
                {
                    N1[i].SetActive(true);
                    if (NA.playerSummonable[i] == false)
                    {
                        N1[i].SetActive(false);
                    }
                }
            }
            else if (TM.EnemyTurn)
            {
                for (int i = 0; i <= 8; i++)
                {
                    N1[i].SetActive(true);
                    if (NA.player2Summonable[i] == false)
                    {
                        N1[i].SetActive(false);
                    }
                }
            }
        }
    }

    void OnMouseUp() 
    {
        StartCoroutine(ActivateWait());
    }
}