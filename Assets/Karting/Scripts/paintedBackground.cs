using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paintedBackground : MonoBehaviour
{
    public int red;
    public int green;
    public int blue;

    void Start()
    {
        //Assigning random color values to change the Color32 of our image.
        red = Random.Range(0, 140);
        green = Random.Range(0, 140);
        blue = Random.Range(0, 140);

        //Setting the color of the image to our random values.
        RawImage image = GetComponent<RawImage>();
        image.color = new Color32((byte)red, (byte)green, (byte)blue, 160);
    }

    void update()
    {

    }

}
