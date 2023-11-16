using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    [SerializeField] private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        ColorPicker();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,2,0));
    }

    void ColorPicker()
    {
        Color[] colors = new Color[3];
        colors[0] = Color.red;
        colors[1] = Color.blue;
        colors[2] = Color.green;

        if (i > 2)
            i = 0;

        StartCoroutine(ChangeColor(colors[i]));
        i++;

    }
    IEnumerator ChangeColor(Color color)
    {
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Renderer>().material.color = color;
        ColorPicker();

    }
}
