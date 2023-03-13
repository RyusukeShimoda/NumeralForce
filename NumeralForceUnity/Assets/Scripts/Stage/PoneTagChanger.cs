using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoneTagChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag=="PoneP") 
        {
            if (this.tag == "SA1") 
            {
                other.tag = "SA1P";
            }
            if (this.tag == "SA2")
            {
                other.tag = "SA2P";
            }
            if (this.tag=="SA3") 
            {
                other.tag = "SA3P";
            }
            if (this.tag == "SA4")
            {
                other.tag = "SA4P";
            }
            if (this.tag == "SB1")
            {
                other.tag = "SB1P";
            }
            if (this.tag == "SB2")
            {
                other.tag = "SB2P";
            }
            if (this.tag == "SB3")
            {
                other.tag = "SB3P";
            }
            if (this.tag == "SB4")
            {
                other.tag = "SB4P";
            }
            if (this.tag == "SC1")
            {
                other.tag = "SC1P";
            }
            if (this.tag == "SC2")
            {
                other.tag = "SC2P";
            }
            if (this.tag == "SC3")
            {
                other.tag = "SC3P";
            }
            if (this.tag == "SC4")
            {
                other.tag = "SC4P";
            }
        }
        else if (other.tag == "PoneE")
        {
            if (this.tag == "SA1")
            {
                other.tag = "SA1E";
            }
            if (this.tag == "SA2")
            {
                other.tag = "SA2E";
            }
            if (this.tag == "SA3")
            {
                other.tag = "SA3E";
            }
            if (this.tag == "SA4")
            {
                other.tag = "SA4E";
            }
            if (this.tag == "SB1")
            {
                other.tag = "SB1E";
            }
            if (this.tag == "SB2")
            {
                other.tag = "SB2E";
            }
            if (this.tag == "SB3")
            {
                other.tag = "SB3E";
            }
            if (this.tag == "SB4")
            {
                other.tag = "SB4E";
            }
            if (this.tag == "SC1")
            {
                other.tag = "SC1E";
            }
            if (this.tag == "SC2")
            {
                other.tag = "SC2E";
            }
            if (this.tag == "SC3")
            {
                other.tag = "SC3E";
            }
            if (this.tag == "SC4")
            {
                other.tag = "SC4E";
            }
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if(other.tag=="SA1P"||other.tag == "SA2P" || other.tag == "SA3P" || other.tag == "SA4P" || other.tag == "SB1P" || other.tag == "SB2P" || other.tag == "SB3P" || other.tag == "SB4P" || other.tag == "SC1P" || other.tag == "SC2P" || other.tag == "SC3P" || other.tag == "SC4P") 
        {
            other.tag = "PoneP";
        }
        else if (other.tag == "SA1E" || other.tag == "SA2E" || other.tag == "SA3E" || other.tag == "SA4E" || other.tag == "SB1E" || other.tag == "SB2E" || other.tag == "SB3E" || other.tag == "SB4E" || other.tag == "SC1E" || other.tag == "SC2E" || other.tag == "SC3E" || other.tag == "SC4E")
        {
            other.tag = "PoneE";
        }
    }
}
