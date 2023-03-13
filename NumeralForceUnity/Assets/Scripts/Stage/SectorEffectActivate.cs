using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SectorEffectActivate : MonoBehaviour
{
    public TurnManager TM;
    public TheNumber TN;

    public GameObject LE;
    public GameObject StE;
    public GameObject RE;

    public GameObject LES;
    public GameObject StES;
    public GameObject RES;

    public GameObject pone;
    public GameObject[] selector;
    [SerializeField] Material Through;
    [SerializeField] Material Blue;
    [SerializeField] BoxCollider BoxCol;

    void Start()
    {
        TM = GameObject.Find("GrandAdvisor").GetComponent<TurnManager>();
    }

    void Update()
    {
        selector = GameObject.FindGameObjectsWithTag("Selected");
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 pos = this.transform.position;
            pos.y = 1.12f;
            this.transform.position = pos;
        }

        if(TN.number > 0 && selector.Length == 0) 
        {
            pone.GetComponent<Renderer>().material = Blue;
            //if (this.name == "PoneBlue(Clone)") 
            //{ 
            //    pone.GetComponent<Renderer>().material.color = new Color(0, 100, 255, 50);
            //    pone.GetComponent<Renderer>().material.SetFloat("_Metallic", 1.0f);
            //    pone.GetComponent<Renderer>().material.SetFloat("_Glossiness", 0.8f);
            //}
            //else if (this.name == "PoneOrange(Clone)" || this.name == "PoneOrangeP(Clone)") pone.GetComponent<Renderer>().material.color = new Color(255, 125, 0, 50);
            BoxCol.enabled = true;
        }
    }

    IEnumerator ActivateWait() 
    {
        yield return null;
        this.transform.DOMoveY(1.13f, 0.1f);
        if(this.name== "PoneBlue(Clone)" && TM.PlayerTurn) 
        {
            if (this.tag == "SA2P" || this.tag == "SA3P" || this.tag == "SA4P")
            {
                StE.SetActive(true);
                RE.SetActive(true);
                StE.GetComponent<BoxCollider>().enabled = true;
                RE.GetComponent<BoxCollider>().enabled = true;
                StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                RE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                StES.tag = "Selected";
                RES.tag = "Selected";
            }
            else if (this.tag == "SB2P" || this.tag == "SB3P" || this.tag == "SB4P")
            {
                LE.SetActive(true);
                StE.SetActive(true);
                RE.SetActive(true);
                LE.GetComponent<BoxCollider>().enabled = true;
                StE.GetComponent<BoxCollider>().enabled = true;
                RE.GetComponent<BoxCollider>().enabled = true;
                LE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                RE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                LES.tag = "Selected";
                StES.tag = "Selected";
                RES.tag = "Selected";
            }
            else if (this.tag == "SC2P" || this.tag == "SC3P" || this.tag == "SC4P")
            {
                LE.SetActive(true);
                StE.SetActive(true);
                LE.GetComponent<BoxCollider>().enabled = true;
                StE.GetComponent<BoxCollider>().enabled = true;
                LE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                LES.tag = "Selected";
                StES.tag = "Selected";
            }
        }
        else if (this.name == "PoneOrangeP(Clone)" && TM.EnemyTurn)
        {
            if (this.tag == "SA1E" || this.tag == "SA2E" || this.tag == "SA3E")
            {
                LE.SetActive(true);
                StE.SetActive(true);
                LE.GetComponent<BoxCollider>().enabled = true;
                StE.GetComponent<BoxCollider>().enabled = true;
                LE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                LES.tag = "Selected";
                StES.tag = "Selected";
            }
            else if (this.tag == "SB1E" || this.tag == "SB2E" || this.tag == "SB3E")
            {
                LE.SetActive(true);
                StE.SetActive(true);
                RE.SetActive(true);
                LE.GetComponent<BoxCollider>().enabled = true;
                StE.GetComponent<BoxCollider>().enabled = true;
                RE.GetComponent<BoxCollider>().enabled = true;
                LE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                RE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                LES.tag = "Selected";
                StES.tag = "Selected";
                RES.tag = "Selected";
            }
            else if (this.tag == "SC1E" || this.tag == "SC2E" || this.tag == "SC3E")
            {
                StE.SetActive(true);
                RE.SetActive(true);
                StE.GetComponent<BoxCollider>().enabled = true;
                RE.GetComponent<BoxCollider>().enabled = true;
                StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                RE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
                StES.tag = "Selected";
                RES.tag = "Selected";
            }
        }
    }

    void OnMouseUp() 
    {
        StartCoroutine(ActivateWait());
    }

    void OnTriggerStay(Collider other) 
    {
        if (other.tag == "Selected") 
        {
            pone.GetComponent<Renderer>().material = Through;
            //if (this.name == "PoneBlue(Clone)") 
            //{ 
            //    pone.GetComponent<Renderer>().material.color = new Color(0, 100, 255, 50);
            //    pone.GetComponent<Renderer>().material.SetFloat("_Metallic", 1.0f);
            //    pone.GetComponent<Renderer>().material.SetFloat("_Glossiness", 0.8f);
            //}
            //else if (this.name == "PoneOrange(Clone)" || this.name == "PoneOrangeP(Clone)") pone.GetComponent<Renderer>().material.color = new Color(255, 125, 0, 50);
            BoxCol.enabled = false;

        }
    }
}
