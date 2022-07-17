using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarterButton : MonoBehaviour
{
    private Animator drawerAnim, requirementAnim;
    public static int previousDice = -1;

    public GameObject requirement;

    // Start is called before the first frame update
    void Start()
    {
        drawerAnim = gameObject.GetComponentInChildren<Animator>();
        requirementAnim = requirement.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (previousDice == -1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log(drawerAnim.GetBool("Closed"));
        if (drawerAnim.GetBool("Closed"))
        {
            drawerAnim.SetBool("Closed", false);
            drawerAnim.SetTrigger("Button_Clicked");
            requirementAnim.SetBool("Closed", false);
            requirementAnim.SetTrigger("Button_Clicked");
        } else
        {
            drawerAnim.SetBool("Closed", true);
            drawerAnim.SetTrigger("Button_Clicked");
            requirementAnim.SetBool("Closed", true);
            requirementAnim.SetTrigger("Button_Clicked");
        }
    }
}
