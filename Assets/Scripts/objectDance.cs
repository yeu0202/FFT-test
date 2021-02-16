using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDance : MonoBehaviour
{
    public int objectKey = 3; // 0-7
    Material[] objectMaterial = new Material[1];

    // Start is called before the first frame update
    void Start()
    {
        objectMaterial[0] = this.GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1, (float)(AudioAnalysis.bandBuffer[objectKey] * AudioAnalysis.blockScale + 0.04), 1);
        float tempValue = AudioAnalysis.bandBuffer[objectKey] / AudioAnalysis.maxValue[objectKey];
        Color _color = new Color(tempValue, tempValue, tempValue);
        objectMaterial[0].SetColor("_EmissionColor", _color);
    }
}
