using System.Collections;
using System.Collections.Generic;
using MakeRotateLibrary.Core;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private GameObject inputCube;
    [SerializeField] private GameObject outputCube;
    
    void Start()
    {
    }

    void Update()
    {
        outputCube.transform.rotation = MakeRotateCore.GetLookAtTarget_Z(outputCube.transform, inputCube.transform);
        outputCube.transform.rotation = MakeRotateCore.GetLookAtTarget_Y(outputCube.transform, inputCube.transform);
        // outputCube.transform.LookAtTarget_Z(inputCube.transform);
    }
}
