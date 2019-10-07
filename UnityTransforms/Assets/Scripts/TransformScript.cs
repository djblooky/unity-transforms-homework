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
        newSquare.transform.localScale *= 5;
    }

    void RotateObject(GameObject g)
    {
        g.transform.Rotate(0, 0, 20, Space.Self);
    }

    void ScaleObject(GameObject g)
    {
        g.transform.localScale *= new Vector2(2, 2); 
    }

    void TranslateObject(GameObject g)
    {
        g.transform.Translate(new Vector2(5, 5));
    }

}
