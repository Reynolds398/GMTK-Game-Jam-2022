using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    // Yellow = 1, Blue = 2, Red = 3
    public int colourId = 0;
    private Color empty = new Color(0, 0, 0, 0.3921569f);
    private Color red = new Color(0.9921569f, 0.145098f, 0.05098039f, 0.5882353f);
    private Color yellow = new Color(0.9215687f, 0.9215687f, 0.07058824f, 0.5686275f);
    private Color blue = new Color(0.09803922f, 0.5254902f, 0.8196079f, 0.5686275f);

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (colourId == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = empty;
        }

        if (colourId == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = yellow;
        }

        if (colourId == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = blue;
        }

        if (colourId == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = red;
        }
    }
}
