using UnityEngine;

namespace MakeRotateLibrary.Core
{
    public static class MakeRotateCore
    {
        ///<summary>
        /// Returns rotation that towards Z from source to target
        ///</summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static Quaternion GetLookAtTarget_Z3D(Transform source, Transform target, float multiplier = 1f)
        {
            return Quaternion.Euler(
                new Vector3(
                    source.transform.eulerAngles.x, 
                    Mathf.Atan2(target.transform.position.x - source.transform.position.x, target.transform.position.z - source.transform.position.z) * Mathf.Rad2Deg * multiplier,
                    source.transform.eulerAngles.z
                ));
        }
        
        /// <summary>
        /// Returns rotation X from source to target
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static Quaternion GetLookAtTarget_Y2D(Transform source, Transform target, float multiplier)
        {
            return Quaternion.Euler(
                new Vector3(
                    Mathf.Atan(source.transform.position.y - target.transform.position.y) * Mathf.Rad2Deg * multiplier, 
                    source.transform.eulerAngles.y, 
                    source.transform.eulerAngles.z
                ));
        }

        /// <summary>
        /// Towards Z from source to target
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static void LookAtTarget_Z3D(this Transform source, Transform target, float multiplier = 1f)
        {
            source.transform.rotation = Quaternion.Euler(
                new Vector3(
                    source.transform.eulerAngles.x, 
                    Mathf.Atan2(target.transform.position.x - source.transform.position.x, target.transform.position.z - source.transform.position.z) * Mathf.Rad2Deg * multiplier, 
                    source.transform.eulerAngles.z
                ));
        }
        
        /// <summary>
        /// Towards Z of object to Y position of another object
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static void LookAtTarget_Y2D(this Transform source, Transform target, float multiplier = 1f)
        {
            source.transform.rotation =Quaternion.Euler(new Vector3(
                Mathf.Atan(source.transform.position.y - target.transform.position.y) * Mathf.Rad2Deg * multiplier,
                source.transform.eulerAngles.y,
                source.transform.eulerAngles.z
            ));
        }

        /// <summary>
        /// Towards X from source to target
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static void LookAtTarget_X3D(this Transform source, Transform target, float multiplier = 1f)
        {
            source.transform.rotation = Quaternion.Euler(new Vector3(
                source.transform.eulerAngles.x,
                Mathf.Atan2(source.transform.position.z - target.transform.position.z, target.transform.position.x - source.transform.position.x) * Mathf.Rad2Deg * multiplier,
                source.transform.eulerAngles.z
            ));
        }
    }
}
