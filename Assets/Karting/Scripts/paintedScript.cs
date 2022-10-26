using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paintedScript : MonoBehaviour
{
    public int width;
    public int height;

    public int red;
    public int green;
    public int blue;
    public int alpha;

    public int ranPosX;
    public int ranPosY;

    public int rotation;

    void Start()
    {
        //Assigning random values for RectTransform to reference to.
        width = Random.Range(500, 751);
        height = Random.Range(500, 751);
        ranPosX = Random.Range(-500, 501);
        ranPosY = Random.Range(-300, 301);
        rotation = Random.Range(0, 360);

        //Assigning random color values to change the Color32 of our image.
        red = Random.Range(0, 255);
        green = Random.Range(0, 255);
        blue = Random.Range(0, 255);
        alpha = Random.Range(230, 255);

        //Setting the position of the image to our random values by adding to the anchored position.
        RectTransform picture = GetComponent<RectTransform>();
        picture.anchoredPosition = new Vector2(picture.anchoredPosition.x + ranPosX, picture.anchoredPosition.y + ranPosY);
        picture.Rotate( new Vector3(0, 0, rotation));
        picture.sizeDelta = new Vector2 (width, height);

        //Setting the color of the image to our random values.
        RawImage image = GetComponent<RawImage>();
        image.color = new Color32((byte)red, (byte)green, (byte)blue, (byte)alpha);
    }
}
