using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public static bool rolled = false;
    private int roll, min = 1;
    private GameObject one, two, three, four, five, six;

    public static int bias = 0;
    public GameObject dice;

    // Start is called before the first frame update
    void Start()
    {
        min += bias;
    }

    // Update is called once per frame
    void Update()
    {
        if (!rolled)
        {
            roll = Random.Range(min, 7);
            rolled = true;
        }
    }

    private void OnMouseDown()
    {
        if (roll == 1)
        {
            one.SetActive(false);
            one.SetActive(true);

            Debug.Log("Rolled a one");
        }

        if (roll == 2)
        {
            two.SetActive(false);
            two.SetActive(true);

            Debug.Log("Rolled a two");
        }

        if (roll == 3)
        {
            three.SetActive(false);
            three.SetActive(true);

            Debug.Log("Rolled a three");
        }

        if (roll == 4)
        {
            four.SetActive(false);
            four.SetActive(true);

            Debug.Log("Rolled a four");
        }

        if (roll == 5)
        {
            five.SetActive(false);
            five.SetActive(true);

            Debug.Log("Rolled a five");
        }

        if (roll == 6)
        {
            six.SetActive(false);
            six.SetActive(true);

            Debug.Log("Rolled a six");
        }

        if (roll >= Requirement.rollReq)
        {
            Customer.satisfied = true;
        } else
        {
            Customer.angry = true;
        }
    }

    public void AssignGameObjects()
    {
        dice = dice.transform.GetChild(0).gameObject; // Go to the actual Dice game object
        one = dice.transform.GetChild(0).gameObject;
        two = dice.transform.GetChild(1).gameObject;
        three = dice.transform.GetChild(2).gameObject;
        four = dice.transform.GetChild(3).gameObject;
        five = dice.transform.GetChild(4).gameObject;
        six = dice.transform.GetChild(5).gameObject;
    }
}
