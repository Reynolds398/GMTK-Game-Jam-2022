using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    private Customer customer;

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
        customer.angry = true;
        GameObject.Find("GameManager").GetComponent<GameManager>().left = true;
    }

    public void FindCustomer()
    {
        customer = GameObject.FindGameObjectWithTag("Customer").GetComponent<Customer>();
    }
}
