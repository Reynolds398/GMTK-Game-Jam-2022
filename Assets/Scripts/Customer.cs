using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private Animator customerAnim;
    private NoButton noButton;
    [SerializeField] private GameObject angryFace, neutralFace, happyFace;

    public bool satisfied, angry;

    // Start is called before the first frame update
    void Start()
    {
        customerAnim = GetComponent<Animator>();
        noButton = GameObject.Find("No Button").GetComponent<NoButton>();
        noButton.FindCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        if (satisfied || angry)
        {
            neutralFace.SetActive(false);

            if (angry)
            {
                happyFace.SetActive(false);
            }

            customerAnim.SetTrigger("Leave");
        }
    }
}
