using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Requests : MonoBehaviour
{
    public static int currentRequest, loadRequirement;
    public int request, loadAmount;

    // Start is called before the first frame update
    void Start()
    {
        currentRequest = request;
        loadRequirement = loadAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
