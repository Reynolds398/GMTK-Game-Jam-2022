using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrowButtons : MonoBehaviour
{
    private bool held = false;
    private int max = 5;
    public static int count = 0;

    [SerializeField] private int id;
    [SerializeField] private GameObject unclickedButton;
    [SerializeField] private TextMeshPro amountText;

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

        if (id == 1 && count < max) // Up Arrow
        {
            count++;

            GameObject ball = ObjectPooler.SharedInstance.GetPooledObject();
            if (ball != null)
            {
                ball.transform.position = new Vector3(1.7f, 4, 0);
                //ball.transform.rotation = turret.transform.rotation;
                ball.SetActive(true);
            }
        }

        if (id == 2 && count > 0) // Down Arrow
        {
            count--;
        }

        amountText.SetText(count.ToString());
    }
}
