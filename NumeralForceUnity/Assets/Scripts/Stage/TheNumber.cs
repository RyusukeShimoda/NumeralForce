using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TheNumber : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI tx;
    public NumbersAdvice NA;
    public int TheN;
    public GameObject pone;
    [SerializeField] Material ThroughB;
    [SerializeField] Material ThroughE;
    public int fadeAlpha;

    // Start is called before the first frame update
    void Start()
    {
        fadeAlpha = 255;
        NA = GameObject.Find("GrandAdvisor").GetComponent<NumbersAdvice>();
        number = NA.summonNumber;
        tx.text = number.ToString();
        if (this.tag == "PoneP")
        {
            NA.playerLife -= number;
            NA.playerSummonable[number - 1] = false;
        }
        else if (this.tag == "PoneE") 
        {
            NA.enemyLife -= number;
            if (this.name == "PoneOrangeP(Clone)") NA.player2Summonable[number - 1] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        tx.text = number.ToString();

        if (number <= 0) 
        {
            if (this.name == "PoneBlue(Clone)") FadeOut();
            else if (this.name == "PoneOrange(Clone)" || this.name == "PoneOrangeP(Clone)") FadeOutE();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (this.tag == "PoneP") 
        {
            if (other.name == "PoneBlue(Clone)")
            {
                TheN = other.GetComponent<TheNumber>().number;
                TheN += number;
                other.GetComponent<TheNumber>().number = TheN;
                if (this.tag != "SA2P" && this.tag != "SB2P" && this.tag != "SC2P" && this.tag != "SA3P" && this.tag != "SB3P" && this.tag != "SC3P" && this.tag != "SA4P" && this.tag != "SB4P" && this.tag != "SC4P")
                {
                    FadeOut();
                }
            }
            else if (other.name == "PoneOrange(Clone)"|| other.name == "PoneOrangeP(Clone)")
            {
                TheN = other.GetComponent<TheNumber>().number;
                TheN -= number;
                other.GetComponent<TheNumber>().number = TheN;
                number = -1 * TheN;
                if (TheN >= 0) FadeOut();
            }
        }
        else if (this.tag == "PoneE")
        {
            if (other.name == "PoneOrange(Clone)" || other.name == "PoneOrangeP(Clone)")
            {
                TheN = other.GetComponent<TheNumber>().number;
                TheN += number;
                other.GetComponent<TheNumber>().number = TheN;
                if (this.tag != "SA2E" && this.tag != "SB2E" && this.tag != "SC2E" && this.tag != "SA3E" && this.tag != "SB3E" && this.tag != "SC3E" && this.tag != "SA1E" && this.tag != "SB1E" && this.tag != "SC1E")
                {
                    FadeOutE();
                }
            }
            else if (other.name == "PoneBlue(Clone)")
            {
                TheN = other.GetComponent<TheNumber>().number;
                TheN -= number;
                other.GetComponent<TheNumber>().number = TheN;
                number = -1 * TheN;
                if (TheN >= 0) FadeOutE();
            }
        }
    }

    public void FadeOut() 
    {
        transform.Find("Canvas").transform.Find("Text (TMP)").gameObject.SetActive(false);
        //pone.GetComponent<Renderer>().material = ThroughB;
        //StartCoroutine("FadePone");
        Invoke("Exit", 0.1f);
    }

    public void FadeOutE()
    {
        transform.Find("Canvas").transform.Find("Text (TMP)").gameObject.SetActive(false);
        //pone.GetComponent<Renderer>().material = ThroughE;
        //StartCoroutine("FadePone");
        Invoke("Exit", 0.1f);
    }

    //IEnumerator FadePone()
    //{
    //    for (int i = 0; i < 255; i++)
    //    {
    //        pone.GetComponent<Renderer>().material.color = pone.GetComponent<Renderer>().material.color - new Color(0, 0, 0, 1);
    //        yield return new WaitForSeconds(0.01f);
    //    }
    //}

    void Exit() 
    {
        Destroy(this.gameObject);
    }
}
