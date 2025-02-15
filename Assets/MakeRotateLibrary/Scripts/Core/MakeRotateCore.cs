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
        public static Quaternion GetLookAtTarget_Z(Transform source, Transform target)
        {
            return Quaternion.Euler(
                new Vector3(
                    source.transform.eulerAngles.x, 
                    Mathf.Atan2(target.transform.position.x - source.transform.position.x, target.transform.position.z - source.transform.position.z) * Mathf.Rad2Deg, 
                    source.transform.eulerAngles.z
                ));
        }
        
        /// <summary>
        /// Returns rotation X from source to target
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static Quaternion GetLookAtTarget_Y(Transform source, Transform target)
        {
            return Quaternion.Euler(
                new Vector3(
                    Mathf.Atan(source.transform.position.y - target.transform.position.y) * Mathf.Rad2Deg, 
                    source.transform.eulerAngles.y, 
                    source.transform.eulerAngles.z
                ));
        }
        
        /// <summary>
        /// Towards Z from source to target
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static void LookAtTarget_Z(this Transform source, Transform target)
        {
            source.transform.rotation = Quaternion.Euler(
                new Vector3(
                    source.transform.eulerAngles.x, 
                    Mathf.Atan2(target.transform.position.x - source.transform.position.x, target.transform.position.z - source.transform.position.z) * Mathf.Rad2Deg, 
                    source.transform.eulerAngles.z
                ));
        }
        
        /// <summary>
        /// Towards X from source to target
        /// </summary>
        /// <param name="source">Source Transform</param>
        /// <param name="target">Target Transform</param>
        public static void LookAtTarget_Y(this Transform source, Transform target)
        {
            source.transform.rotation =Quaternion.Euler(new Vector3(
                Mathf.Atan(source.transform.position.y - target.transform.position.y) * Mathf.Rad2Deg,
                source.transform.eulerAngles.y,
                source.transform.eulerAngles.z
            ));
        }
    }
}
