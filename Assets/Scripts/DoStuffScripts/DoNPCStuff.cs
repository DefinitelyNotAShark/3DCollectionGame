using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoNPCStuff : MonoBehaviour, Iinteractable
{
    private enum Mission { none, woodMission, wellMission, barnMission, murderMission }//this is the possible missions the NPC could start

    [SerializeField]
    private Mission thisNPCMission;

    [SerializeField]
    private string[] npcText;

    public Color NpcColor;

    //These are things we need to find on awake with tag
    private Text interactText;
    private GameObject dialoguePanel;
    private Text npcDialogueText;
    private Text continueIcon;
    private Image bunnyAvatar;
    private MissionPanelUI missionPanelScript;
    private GameObject woodUI;

    private float letterPause = .05f;

    private bool interacted = false;
    private string message;

    private int dialogueIndex = 0;//tells us how many lines the NPC has
    private int dialogueMax;//tells us how many lines we've seen from the NPC. Use to figure out when to stop!
    private bool canInteract = true;
   
    private void Awake()
    {
        interactText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
        dialoguePanel = GameObject.FindGameObjectWithTag("DialoguePanel");
        npcDialogueText = GameObject.FindGameObjectWithTag("NPCDialogueText").GetComponent<Text>();
        continueIcon = GameObject.FindGameObjectWithTag("ContinueIcon").GetComponent<Text>();
        bunnyAvatar = GameObject.FindGameObjectWithTag("BunnyAvatar").GetComponent<Image>();
        woodUI = GameObject.FindGameObjectWithTag("WoodUI");
        missionPanelScript = GameObject.FindGameObjectWithTag("MissionPanel").GetComponent<MissionPanelUI>();
    }

    private void Start()
    {
        dialoguePanel.gameObject.SetActive(false);
        dialogueMax = npcText.Length;
    }

    void SetAvatarColor()
    {
        bunnyAvatar.color = NpcColor;//this sets the color of the avatar we see
    }

    public bool CanInteract()//can talk to people unless...maybe when u are in kill mode???
    {
        return true;
    }

    public void HighlightObjectText()
    {
        interactText.gameObject.SetActive(true);

        if(interacted == false)
        interactText.text = "Talk";
    }

    public void Interact()
    {
        if (canInteract)
        {
            SetAvatarColor();//changes avatar color

            interacted = true;//this is so u can't just flick through the entirety of the conversation
            GlobalVars.playerCanMove = false;//this holds the player still while they talk to the NPC
            interactText.text = "";//clears text
            interactText.gameObject.SetActive(false);//this takes away the "TALK" prompt

            //StartCoroutine(InteractBuffer());//this starts the time between where u can click through text

            dialoguePanel.gameObject.SetActive(true);//now we can see the dialogue panel!

            if (dialogueIndex < dialogueMax)//if the NPC has more stuff to say, go to the next string
            {
                message = npcText[dialogueIndex].ToString();
                StartCoroutine(WriteOutText());
                dialogueIndex++;
            }

            else if (dialogueIndex == dialogueMax)//if it's said all it needs to, turn off the panel, and go to the last string
            {
                StartCoroutine(InteractBuffer());
                dialoguePanel.SetActive(false);//if u done, it becomes invisible
                GlobalVars.playerCanMove = true;
                interacted = false;
                dialogueIndex = dialogueMax - 1;//goes back to saying the last thing if u interact with him again  

                if (thisNPCMission == Mission.woodMission)//start mission here!
                {
                    missionPanelScript.StartMission("Collect 100 Wood!");
                    woodUI.gameObject.SetActive(true);
                    GlobalVars.woodMission = true;
                }
            }
        }
    }

    public void StopText()
    {       
        interactText.text = "";
        interactText.gameObject.SetActive(false);
        dialoguePanel.gameObject.SetActive(false);
    }

    IEnumerator InteractBuffer()//wait .5 before taking in new input so that holding down a button won't make it skip through super fast
    {
        canInteract = false;
        yield return new WaitForSeconds(.5f);
        canInteract = true;
    }

    IEnumerator WriteOutText()
    {
        canInteract = false;//this is so we can't skip through this shit
        npcDialogueText.text = "";//clear text each time before animating new text
        continueIcon.gameObject.SetActive(false);//we take away the continue icon for the time when it's animating
        foreach (char c in message.ToCharArray())
        {
            npcDialogueText.text += c;//add new letter and then wait and add another one. (then at the end, put the end symbol)
            yield return new WaitForSeconds(letterPause);
        }
        yield return new WaitForSeconds(letterPause * 4);//lil pause before continue button shows up
        continueIcon.gameObject.SetActive(true);//then the icon shows up and indicates that it's ok to press buttons now.
        canInteract = true;
    }
}
