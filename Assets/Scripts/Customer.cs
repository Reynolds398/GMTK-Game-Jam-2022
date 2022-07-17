using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private Animator customerAnim;
    private NoButton noButton;
    private DialogueManagerStore dialogueManager;
    [SerializeField] private GameObject angryFace, neutralFace, happyFace;

    public static bool satisfied, angry;

    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = GameObject.Find("Dialogue Manager").GetComponent<DialogueManagerStore>();
        dialogueManager.FindCustomer();
        DialogueManagerStore.currentDialogue = 0;
        customerAnim = GetComponent<Animator>();
        noButton = GameObject.Find("No Button").GetComponent<NoButton>();
        noButton.FindCustomer(); // Make No find this customer
    }

    // Update is called once per frame
    void Update()
    {
        if (satisfied || angry)
        {
            neutralFace.SetActive(false);

            if (satisfied)
            {
                DialogueManagerStore.currentDialogue = 1;
            }

            if (angry)
            {
                happyFace.SetActive(false);
                DialogueManagerStore.currentDialogue = 2;
            }

            StartCoroutine(DelayedLeave());
        }
    }

    IEnumerator DelayedLeave()
    {
        satisfied = false;
        angry = false;
        GameManager.left = true;
        Roll.rolled = false;
        yield return new WaitForSeconds(2);
        customerAnim.SetTrigger("Leave");
    }
}
