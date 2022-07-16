using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private Animator customerAnim;
    private NoButton noButton;

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
            customerAnim.SetTrigger("Leave");
        }
    }
}
