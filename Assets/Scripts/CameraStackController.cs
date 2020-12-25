using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Camera))]
public class CameraStackController : MonoBehaviour
{
    Camera baseCamera = null;
    float elapsedTime = 0f;

    void Start()
    {
        baseCamera = GetComponent<Camera>();
    }

    void Update()
    {
        var cameraData = baseCamera.GetUniversalAdditionalCameraData();
        elapsedTime += Time.deltaTime;
        Debug.Log(cameraData.cameraStack);//ここは一個
        if (elapsedTime > 5f)
        {
            if (cameraData.cameraStack.Count >= 1)
            {
                cameraData.cameraStack.Clear();
            }
        }
    }
}
