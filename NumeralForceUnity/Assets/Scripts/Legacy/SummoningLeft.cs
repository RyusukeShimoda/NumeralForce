using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummoningLeft : MonoBehaviour
{
    public GameObject pone;
    public Material SectorEffect;
    public Material Through;

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
            this.tag = "SA4";
        }
    }

    void OnMouseDown() 
    {
        if (this.tag == "Selected")
        {
            Instantiate(pone, new Vector3(-4, 16.12f, -6.9f), Quaternion.identity);
        }
    }
}
