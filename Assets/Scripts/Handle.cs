using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour
{
    [SerializeField] private GameObject popUp;
    [SerializeField] private CustomizationManager customize;

    // Start is called before the first frame update
    void Start()
    {
        customize = GameObject.Find("Customization Manager").GetComponent<CustomizationManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        popUp.SetActive(true);
        customize.CreateDice();
    }
}
