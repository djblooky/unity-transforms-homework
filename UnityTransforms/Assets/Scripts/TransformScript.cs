using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransformScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Square;

    [SerializeField]
    private Button ScaleButton, RotateButton, TranslateButton;

    private GameObject newSquare;
    short scaleCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        CreateButtonListeners();
        CreateSquare();
    }

    void CreateButtonListeners()
    {
        RotateButton.onClick.AddListener(delegate { RotateObject(newSquare); });
        TranslateButton.onClick.AddListener(delegate { TranslateObject(newSquare); });
        ScaleButton.onClick.AddListener(delegate { ScaleObject(newSquare); });
    }

    void CreateSquare()
    {
        newSquare = Instantiate(Square, new Vector2(0, 0), Quaternion.identity);
    }

    void RotateObject(GameObject g)
    {
        g.transform.Rotate(90,0,0);
    }

    void ScaleObject(GameObject g)
    {
        if(scaleCount < 5)
            g.transform.localScale *= new Vector2(2, 2);
        scaleCount++;
    }

    void TranslateObject(GameObject g)
    {
        g.transform.Translate(new Vector2(1, 1));
    }
}
