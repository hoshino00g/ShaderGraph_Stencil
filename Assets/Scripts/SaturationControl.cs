using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class SaturationControl : MonoBehaviour
{
    [SerializeField] Material material = null;

    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = new Material(material);
        
    }

    // Update is called once per frame
    void Update()
    {
        var saturation = (Mathf.Sin(Time.time) + 1f) / 2f;
        meshRenderer.material.SetFloat("_Saturation", saturation);//ここでBlackboardに指定した値を入力する。
        
    }
}
