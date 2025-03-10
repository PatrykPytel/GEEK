using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public string strText;
    private bool once  = true;
    private GameObject ESCAPE;
   
    private TMP_Text m_TextComponent;
    private void Awake()
    {
        ESCAPE = GameObject.Find("ESCAPE");
        m_TextComponent = GetComponent<TMP_Text>();
        
    }
    void Start()
    {
       
        
         
        
      

    }

    IEnumerator AnimateText(string strComplete)
    {
        int i = 0;
        
        while (i < strComplete.Length)
        {
            m_TextComponent.text += strComplete[i++];
            yield return new WaitForSeconds(0.1f);
        }
        
    }
    public void Animate()
    {
        if(once)
        {
            ESCAPE.GetComponent<RESULTS>().CURRENTINFO += 1;
            StartCoroutine(AnimateText(strText));
        }
        once = false;
    }
}
