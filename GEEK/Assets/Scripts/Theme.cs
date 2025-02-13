using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Theme : MonoBehaviour
{
    public GameObject Tytul;
    public GameObject Credits;
    public float cooldown = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Tytul.GetComponent<Fade>().HideUI();
            while (cooldown <= 0)
            {
                cooldown -= Time.deltaTime;
            }
            Credits.GetComponent<Fade>().ShowUI();
        }
    }
}
