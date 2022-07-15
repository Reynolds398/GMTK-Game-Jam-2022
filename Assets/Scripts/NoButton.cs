using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    private Customer customer;

    // Start is called before the first frame update
    void Start()
    {
        customer = GameObject.FindGameObjectWithTag("Customer").GetComponent<Customer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        customer.angry = true;
    }
}
