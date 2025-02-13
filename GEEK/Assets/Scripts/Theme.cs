using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theme : MonoBehaviour
{
    public GameObject Tytul;
    public GameObject Credits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Tytul.SetActive(false);
            Credits.SetActive(true);
        }
    }
}
