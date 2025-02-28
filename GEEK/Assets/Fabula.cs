using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabula : MonoBehaviour
{
    public GameObject fabu³a;
    public GameObject fabu³a1;
    public GameObject fab2;
    int fabulacount = 2000;
    int fabula1count = 3000;
    int fabula2count = 3000;
    bool showfab = false;
    // Start is called before the first frame update
    void Start()
    {
        fabu³a.SetActive(false);
        showfab = true;
        fabu³a1.SetActive(false);
        fab2.SetActive(false);
        fabu³a.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
  
      

        
        if (showfab)
        {
            fabulacount--;
            if (fabulacount < 0)
            {
                fabu³a.SetActive(false);
                fab2.SetActive(false);
                fabu³a1.SetActive(true);
                fabula1count--;
            }
            if (fabulacount == 0)
            {
                fabu³a.SetActive(false);
                fab2.SetActive(false);
                fabu³a1.SetActive(true);
                fabula1count--;
            }
            if (fabula1count < 0)
            {
                fabu³a1.SetActive(false);
                fab2.SetActive(true);
                fabula2count--;
            }
            if (fabula1count == 0)
            {
                fabu³a1.SetActive(false);
                fab2.SetActive(true);
                fabula2count--;
            }
            if (fabula2count < 0)
            {
                fab2.SetActive(false);
            }
            if (fabula2count == 0)
            {
                fab2.SetActive(false);
            }

        }

        if ((fabulacount <= 0) && (fabula1count <= 0) && (fabula2count <= 0))
        {
            showfab = false;
        }
    }
}
