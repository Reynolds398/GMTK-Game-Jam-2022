using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManagerStore : MonoBehaviour
{
    [SerializeField] private TextMeshPro text;
    private DialogueList dialogue;
    public static int currentDialogue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(dialogue.sentences[currentDialogue]);
    }

    public void FindCustomer()
    {
        dialogue = GameObject.FindGameObjectWithTag("Customer").GetComponent<DialogueList>();
    }
}
