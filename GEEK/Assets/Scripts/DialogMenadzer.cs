using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.U2D.IK;

public class DialogMenadzer : MonoBehaviour
{
    public Image actorImage;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;
    public GameObject fabu³a;
    public GameObject fabu³a1;
    public GameObject fab2;
    int fabulacount = 5000;
    int fabula1count = 5000;
    int fabula2count = 5000;
    bool showfab = false;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;

        // Debug.Log("Started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f);
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        AnimateTextColor();
    }


    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            //  Debug.Log("Conversation ended");
            isActive = false;
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
        }
    }
    void AnimateTextColor()
    {
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
        fabu³a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            NextMessage();
        }

        if (isActive == false)
        {
            showfab = true;
            fabu³a1.SetActive(false);
            fab2.SetActive(false);
            fabu³a.SetActive(true);

        }
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
 
        if((fabulacount<=0) && (fabula1count<=0) && (fabula2count<=0))
        {
            showfab = false;
        }
    }
}
   
