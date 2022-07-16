using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialButtons : MonoBehaviour
{
    [SerializeField] private Material materialMenu;
    public bool selected;
    public int id;

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
        if (!selected)
        {
            materialMenu.trigger = true;
            materialMenu.requestId = id;
            Debug.Log(id);
            selected = true;
        }
    }
}
