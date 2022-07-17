using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Requirement : MonoBehaviour
{
    public int rollRequirement;
    public static int rollReq;
    private GameObject barterRequirement;
    private TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        rollReq = rollRequirement;
        barterRequirement = GameObject.Find("Requirement Text");
        text = barterRequirement.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText("Roll " + rollRequirement + " or Higher");
    }
}
