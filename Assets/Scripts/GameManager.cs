using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int startingDay = 0;
    private int currentCustomer = 0;
    private static int customerLeft;
    [SerializeField] private List<GameObject> customers;
    private static int totalDays = 0;
    private static bool firstTime = true;

    public GameObject customer;
    public static bool left = false;
    

    // Start is called before the first frame update
    void Start()
    {
        if (firstTime)
        {
            customerLeft = customers.Count;
            firstTime = false;
        }
        
        CreateCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        currentCustomer = GameObject.FindGameObjectsWithTag("Customer").Length;

        if (startingDay == totalDays && currentCustomer == 0 && customerLeft != 0 && left == true)
        {
            customerLeft--;
            CreateCustomer();
            left = false;
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
        Instantiate(customers[customerLeft - 1]);
    }

    IEnumerator LoadTransition()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Transition");
    }
}
