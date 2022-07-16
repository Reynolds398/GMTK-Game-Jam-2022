using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtons : MonoBehaviour
{
    private bool held = false;
    [SerializeField] private GameObject unclickedButton;

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
    }
}
