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
    void Cooldown()
    {
        Tytul.SetActive(false);
        Credits.GetComponent<Fade>().fadeIn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {

            Tytul.GetComponent<Fade>().fadeOut = true;
            Invoke("Cooldown", cooldown);
            Credits.SetActive(true);
        }
    }
}
