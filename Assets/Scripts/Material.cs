using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{
    public bool woodSelected, metalSelected, classicSelected = true;
    public bool trigger;
    public int requestId = 0;
    [SerializeField] private GameObject[] buttons = new GameObject[3];
    [SerializeField] private GameObject[] clickableButtons = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        buttons[1].gameObject.GetComponent<MaterialButtons>().selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            if (classicSelected)
            {
                classicSelected = false;

                if (requestId == 1) // Wood Button pressed
                {
                    woodSelected = true;
                    buttons[1].GetComponent<MaterialButtons>().selected = false;
                    clickableButtons[0].SetActive(false);
                    clickableButtons[1].SetActive(true);
                }

                if (requestId == 3) // Metal Button pressed
                {
                    metalSelected = true;
                    buttons[1].GetComponent<MaterialButtons>().selected = false;
                    clickableButtons[2].SetActive(false);
                    clickableButtons[1].SetActive(true);
                }
            } else if (metalSelected)
            { 
                metalSelected = false;

                if (requestId == 1) // Wood Button pressed
                {
                    woodSelected = true;
                    buttons[2].GetComponent<MaterialButtons>().selected = false;
                    clickableButtons[0].SetActive(false);
                    clickableButtons[2].SetActive(true);
                }

                if (requestId == 2) // Classic Button pressed
                {
                    classicSelected = true;
                    buttons[2].GetComponent<MaterialButtons>().selected = false;
                    clickableButtons[1].SetActive(false);
                    clickableButtons[2].SetActive(true);
                }
            } else if (woodSelected)
            {
                woodSelected = false;

                if (requestId == 2) // Classic Button pressed
                {
                    classicSelected = true;
                    buttons[0].GetComponent<MaterialButtons>().selected = false;
                    clickableButtons[1].SetActive(false);
                    clickableButtons[0].SetActive(true);
                }

                if (requestId == 3) // Metal Button pressed
                {
                    metalSelected = true;
                    buttons[0].GetComponent<MaterialButtons>().selected = false;
                    clickableButtons[2].SetActive(false);
                    clickableButtons[0].SetActive(true);
                }
            }
            
            trigger = !trigger;
        }
    }
}
