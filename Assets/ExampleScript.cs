using MakeRotateLibrary.Core;
using UnityEngine;

namespace Example
{
    public class ExampleScript : MonoBehaviour
    {
        [SerializeField] private Transform _secondCube;
        void Start()
        {
        
        }

        void Update()
        {
            this.transform.LookAtTarget_Z3D(_secondCube);
            this.transform.LookAtTarget_Y2D(_secondCube);
        }
    }
}
