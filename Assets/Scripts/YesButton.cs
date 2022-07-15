using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class YesButton : MonoBehaviour
{
    private BoxCollider2D button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Workshop");
    }
}
