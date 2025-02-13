using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _group;
    public bool fadeIn = false;
    public bool fadeOut = false;
    public float time = 1f;

    public void ShowUI()
    {
        if (fadeIn)
        {
            if (_group.alpha <= 1)
            {
                _group.alpha += Time.deltaTime * time;
                if (_group.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }
    }
    public void HideUI() 
    {
        if (fadeOut)
        {
            if (_group.alpha >= 0)
            {
                _group.alpha -= Time.deltaTime * time;
                if (_group.alpha <= 0)
                {
                    fadeOut = false;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HideUI();
        ShowUI();
    }    
}
