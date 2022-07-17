using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomizationManager : MonoBehaviour
{
    // Wood = 1, Classic = 2, Metal = 3
    [SerializeField] private Material materialPref;

    // Default = 0, Yellow = 1, Blue = 2, Red = 3
    [SerializeField] private ChangeColour colourPref;

    // Load Dice amount
    [SerializeField] public static ArrowButtons loadTotal;

    [SerializeField] private GameObject[] allDices = new GameObject[12];
    private static int diceId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDice()
    {
        if (materialPref.requestId == 1) // If Wood
        {
            diceId += 8;
        } else if (materialPref.requestId == 2) // If Classic
        {
            diceId += 0;
        } else if (materialPref.requestId == 3) // If Metal
        {
            diceId += 4;
        }

        if (colourPref.colourId == 0) // If Default color
        {
            diceId += 1;
        } else if (colourPref.colourId == 1) // If Yellow color
        {
            diceId += 3;
        } else if (colourPref.colourId == 2) // If Blue color
        {
            diceId += 0;
        } else if (colourPref.colourId == 3) // If Red color
        {
            diceId += 2;
        }

        Instantiate(allDices[diceId], gameObject.transform);
    }
}
