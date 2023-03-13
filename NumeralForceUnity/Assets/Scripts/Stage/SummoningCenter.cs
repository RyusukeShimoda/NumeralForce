using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SummoningCenter : MonoBehaviour
{
    public GameObject pone;
    public Material SectorEffect;
    public Material Through;
    public TurnManager TM;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Renderer>().material = Through;
            if (this.name == "SA4") this.tag = "SA4";
            else if (this.name == "SB4") this.tag = "SB4";
            else if (this.name == "SC4") this.tag = "SC4";
            else if (this.name == "SA1") this.tag = "SA1";
            else if (this.name == "SB1") this.tag = "SB1";
            else if (this.name == "SC1") this.tag = "SC1";
        }
    }

    void OnMouseDown()
    {
        if (this.tag == "Selected")
        {
            if (TM.PlayerTurn) 
            {
                if (this.name == "SA4") Instantiate(pone, new Vector3(-4, 16.12f, -6.9f), Quaternion.identity);
                else if (this.name == "SB4") Instantiate(pone, new Vector3(0, 16.12f, -6.9f), Quaternion.identity);
                else if (this.name == "SC4") Instantiate(pone, new Vector3(4, 16.12f, -6.9f), Quaternion.identity);
                TM.PlayerTurn = false;
                DOVirtual.DelayedCall(1, () => TM.TurnTurnE());
            }
            else if (TM.EnemyTurn) 
            {
                if (this.name == "SA1") Instantiate(pone, new Vector3(-4, 16.12f, 6.9f), Quaternion.identity);
                else if (this.name == "SB1") Instantiate(pone, new Vector3(0, 16.12f, 6.9f), Quaternion.identity);
                else if (this.name == "SC1") Instantiate(pone, new Vector3(4, 16.12f, 6.9f), Quaternion.identity);
                TM.EnemyTurn = false;
                DOVirtual.DelayedCall(1, () => TM.TurnTurnP());
            }
        }
    }
}
