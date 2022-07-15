using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private Animator customerAnim;
    [SerializeField] private bool satisfied;

    // Start is called before the first frame update
    void Start()
    {
        customerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (satisfied)
        {
            customerAnim.SetTrigger("Leave");
        }
    }
}
