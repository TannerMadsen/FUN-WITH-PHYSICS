using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Material Good;
    public Material Bad;
    
    private Color targetColor;
    public float Intensity;
    

    // Start is called before the first frame update
    void Start()
    {
        ColorRandomize();
    }

    // Update is called once per frame
    void ColorRandomize(){
        float H, S, V;
        targetColor = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
        Good.color = targetColor;
        Good.SetColor("_EmissionColor", targetColor * Intensity);
        Color.RGBToHSV(targetColor, out H, out S, out V);
        Bad.color = Color.HSVToRGB(Mathf.Repeat(H+0.5f, 1), 1, 1);
        Bad.SetColor("_EmissionColor", Color.HSVToRGB(Mathf.Repeat(H+0.5f, 1), 1, 1)* Intensity);
        

    }
}
