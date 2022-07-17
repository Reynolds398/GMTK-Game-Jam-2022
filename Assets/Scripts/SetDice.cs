using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDice : MonoBehaviour
{
    [SerializeField] private GameObject[] allDices = new GameObject[12];
    [SerializeField] private Roll roll;
    private bool created = false;
    private int previousDice = BarterButton.previousDice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (previousDice >= 0 && previousDice <= 11 && !created)
        {
            CreateDice();
            roll.AssignGameObjects();
            created = true;
        }
    }

    private void CreateDice()
    {
        Instantiate(allDices[previousDice], gameObject.transform);
    }
}
