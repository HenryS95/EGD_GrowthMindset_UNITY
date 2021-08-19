using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


[System.Serializable]

public class NPC : MonoBehaviour
{

    [SerializeField] Transform ChatBackGround;
    [SerializeField] Transform NPCCharacter;

    [SerializeField] DialogueSystem dialogueSystem;

    [SerializeField] string Name;

    //Provides the amounts of line to write on 
    [TextArea(5, 10)]
    public string[] sentences;



    // Start is called before the first frame update
    void Start()
    {
        //Finds dialogue system
        dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    // Update is called once per frame
    void Update()
    {
         //places dialogue box above npc
        // Vector3 Pos = Camera.main.WorldToScreenPoint(NPCCharacter.position);
        //Pos.y += 175;
        //ChatBackGround.position = Pos;
    }


    //collider trigger, calls text and names
    public void OnTriggerStay(Collider other)
    {
        this.gameObject.GetComponent<NPC>().enabled = true;
        FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
        if ((other.gameObject.tag == "Player")&& Input.GetKeyDown(KeyCode.F))
        {
            this.gameObject.GetComponent<NPC>().enabled = true;
            dialogueSystem.Names = Name;
            dialogueSystem.dialogueLines = sentences;
            FindObjectOfType<DialogueSystem>().NPCName();
        }
    }

    //Reset system
    public void OnTriggerExit()
    {
        FindObjectOfType<DialogueSystem>().OutOfRange();
        this.gameObject.GetComponent<NPC>().enabled = false;
    }
}
