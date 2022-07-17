using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int startingDay = 0;
    private int currentCustomer = 0;
    private int customerLeft = 5;
    private static int totalDays = 0;

    public GameObject customer;
    public bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        CreateCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        currentCustomer = GameObject.FindGameObjectsWithTag("Customer").Length;

        if (startingDay == totalDays && currentCustomer == 0 && customerLeft != 0)
        {
            CreateCustomer();
        }

        if (customerLeft == 0 && left)
        {
            StartCoroutine(LoadTransition());
            totalDays++;
            customerLeft = 5;
        }
    }

    private void CreateCustomer()
    {
        customerLeft--;
        left = false;
        Instantiate(customer);
    }

    IEnumerator LoadTransition()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Transition");
    }
}
