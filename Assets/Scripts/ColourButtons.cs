using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourButtons : MonoBehaviour
{
    public int id;
    [SerializeField] private ChangeColour panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        panel.colourId = id;
    }
}
