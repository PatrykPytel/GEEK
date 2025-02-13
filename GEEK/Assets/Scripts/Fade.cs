using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _group;
    public float time = 1f;

    public void ShowUI()
    {
            while (_group.alpha <= 1)
            {
                _group.alpha += Time.deltaTime * time;
            }
    }
    public void HideUI() 
    {
            while (_group.alpha >= 0)
            {
                _group.alpha -= Time.deltaTime * time;
            }
    }

    // Start is called before the first frame update

        
}

    // Update is called once per frame
