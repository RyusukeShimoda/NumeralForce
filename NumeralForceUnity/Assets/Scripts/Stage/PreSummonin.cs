using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreSummonin : MonoBehaviour
{
    public GameObject SA4;
    public GameObject SB4;
    public GameObject SC4;
    public GameObject SA1;
    public GameObject SB1;
    public GameObject SC1;
    [SerializeField] Material SectorEffect;
    [SerializeField] Material Through;
    [SerializeField] int giveSumNum;
    public NumbersAdvice NA;
    public TurnManager TM;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ActivateWait()
    {
        yield return null;
        if (TM.PlayerTurn) 
        {
            SA4.GetComponent<Renderer>().material = SectorEffect;
            SB4.GetComponent<Renderer>().material = SectorEffect;
            SC4.GetComponent<Renderer>().material = SectorEffect;
            SA4.tag = "Selected";
            SB4.tag = "Selected";
            SC4.tag = "Selected";
        }
        else if (TM.EnemyTurn) 
        {
            SA1.GetComponent<Renderer>().material = SectorEffect;
            SB1.GetComponent<Renderer>().material = SectorEffect;
            SC1.GetComponent<Renderer>().material = SectorEffect;
            SA1.tag = "Selected";
            SB1.tag = "Selected";
            SC1.tag = "Selected";
        }
    }

    void OnMouseDown()
    {
        NA.summonNumber = giveSumNum;
        StartCoroutine(ActivateWait());
    }
}
