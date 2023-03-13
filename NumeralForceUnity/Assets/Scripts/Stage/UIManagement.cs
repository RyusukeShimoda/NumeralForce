using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManagement : MonoBehaviour
{

    [SerializeField]
    [Header("引数・数字UIオブジェクト")]
    public GameObject N1;
    public GameObject N2;
    public GameObject N3;
    public GameObject N4;
    public GameObject N5;
    public GameObject N6;
    public GameObject N7;
    public GameObject N8;
    public GameObject N9;

    public int ButtonFlag = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointClick() 
    {
        if (ButtonFlag == 0)
        {
            N1.SetActive(true);
            N2.SetActive(true);
            N3.SetActive(true);
            N4.SetActive(true);
            N5.SetActive(true);
            N6.SetActive(true);
            N7.SetActive(true);
            N8.SetActive(true);
            N9.SetActive(true);
            ButtonFlag = 1;
        }
        else if (ButtonFlag == 1)
        {
            N1.SetActive(false);
            N2.SetActive(false);
            N3.SetActive(false);
            N4.SetActive(false);
            N5.SetActive(false);
            N6.SetActive(false);
            N7.SetActive(false);
            N8.SetActive(false);
            N9.SetActive(false);
            ButtonFlag = 0;
        }
    }
}