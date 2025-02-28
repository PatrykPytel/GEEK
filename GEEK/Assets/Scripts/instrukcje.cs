using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instrukcje : MonoBehaviour
{
   
    public GameObject ins;
    public GameObject ins1;
    public GameObject ins2;
    public GameObject ins3;
    public GameObject ins4;
    public GameObject ins5;
    int inscount = 2000;
    int ins1count = 2000;
    int ins2count = 3000;
    int ins3count = 3000;
    int ins4count = 3000;
    int ins5count = 2000;
    bool showins = false;
    
    public void Start()
    {
        ins.SetActive(false);
        ins1.SetActive(false);
        ins2.SetActive(false);
        ins3.SetActive(false);
        ins4.SetActive(false);
        ins5.SetActive(false);
        showins = true;
        ins.SetActive(true);


    }

    // Update is called once per frame
    public void Update()
    {
        if (showins == true)
        {
            ins.SetActive(true);
            inscount--;
            if (inscount < 0)
            {
                ins.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(false);
                ins1.SetActive(true);
                ins1count--;
            }
            if (inscount == 0)
            {
                ins.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(false);
                ins1.SetActive(true);
                ins1count--;
            }
            if (ins1count < 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(true);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(false);
                ins2count--;
            }
            if (ins1count == 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(true);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(false);
                ins2count--;
            }
            if (ins2count < 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(true);
                ins4.SetActive(false);
                ins5.SetActive(false);
                ins3count--;
            }
            if (ins2count == 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(true);
                ins4.SetActive(false);
                ins5.SetActive(false);
                ins3count--;
            }
            if (ins3count < 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(true);
                ins5.SetActive(false);
                ins4count--;
            }
            if (ins3count == 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(true);
                ins5.SetActive(false);
                ins4count--;
            }
            if (ins4count < 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(true);
                ins5count--;
            }
            if (ins4count == 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(true);
                ins5count--;
            }
            if (ins5count < 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(false);
            }
            if (ins5count == 0)
            {
                ins.SetActive(false);
                ins1.SetActive(false);
                ins2.SetActive(false);
                ins3.SetActive(false);
                ins4.SetActive(false);
                ins5.SetActive(false);
            }
        }

        if ((inscount <= 0) && (ins1count <= 0) && (ins2count <= 0) && (ins3count <= 0) && (ins4count <= 0) && (ins5count <= 0))
        {
            showins = false;
        }
    }
}