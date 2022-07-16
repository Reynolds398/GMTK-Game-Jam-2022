using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrowButtons : MonoBehaviour
{
    private bool held = false;
    private int max = 5;
    private static int count = 0;

    [SerializeField] private int id;
    [SerializeField] private GameObject unclickedButton;
    [SerializeField] private TextMeshPro amountText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!held)
        {
            unclickedButton.SetActive(true);
        }
        
    }

    private void OnMouseDrag()
    {
        held = true;
        unclickedButton.SetActive(false);
    }

    private void OnMouseUp()
    {
        held = false;

        if (id == 1 && count < max) // Up Arrow
        {
            count++;
        }

        if (id == 2 && count > 0) // Down Arrow
        {
            count--;
        }

        amountText.SetText(count.ToString());
    }
}
