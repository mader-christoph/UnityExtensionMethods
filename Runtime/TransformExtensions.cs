using UnityEngine;

namespace CMIV.UnityExtensionMethods
{
    public static class TransformExtensions
    {
        // --- Local Position ---
        public static void SetLocalPositionX(this Transform t, float x) {
            Vector3 p = t.localPosition;
            p.x = x;
            t.localPosition = p;
        }

        public static void SetLocalPositionY(this Transform t, float y) {
            Vector3 p = t.localPosition;
            p.y = y;
            t.localPosition = p;
        }

        public static void SetLocalPositionZ(this Transform t, float z) {
            Vector3 p = t.localPosition;
            p.z = z;
            t.localPosition = p;
        }

        // --- World Position ---
        public static void SetPositionX(this Transform t, float x) {
            Vector3 p = t.position;
            p.x = x;
            t.position = p;
        }

        public static void SetPositionY(this Transform t, float y) {
            Vector3 p = t.position;
            p.y = y;
            t.position = p;
        }

        public static void SetPositionZ(this Transform t, float z) {
            Vector3 p = t.position;
            p.z = z;
            t.position = p;
        }

        // --- Local Rotation (AngleAxis) ---
        public static void SetLocalRotationX(this Transform t, float angle) {
            t.localRotation = Quaternion.AngleAxis(angle, Vector3.right);
        }

        public static void SetLocalRotationY(this Transform t, float angle) {
            t.localRotation = Quaternion.AngleAxis(angle, Vector3.up);
        }

        public static void SetLocalRotationZ(this Transform t, float angle) {
            t.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        // --- Local Euler Rotation ---
        public static void SetLocalEulerRotationX(this Transform t, float x) {
            Vector3 euler = t.localEulerAngles;
            euler.x = x;
            t.localRotation = Quaternion.Euler(euler);
        }

        public static void SetLocalEulerRotationY(this Transform t, float y) {
            Vector3 euler = t.localEulerAngles;
            euler.y = y;
            t.localRotation = Quaternion.Euler(euler);
        }

        public static void SetLocalEulerRotationZ(this Transform t, float z) {
            Vector3 euler = t.localEulerAngles;
            euler.z = z;
            t.localRotation = Quaternion.Euler(euler);
        }

        // --- World Rotation (Euler Angles) ---
        public static void SetRotationX(this Transform t, float angle) {
            t.rotation = Quaternion.AngleAxis(angle, Vector3.right);
        }

        public static void SetRotationY(this Transform t, float angle) {
            t.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        }

        public static void SetRotationZ(this Transform t, float angle) {
            t.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        // --- World Euler Rotation ---
        public static void SetEulerRotationX(this Transform t, float x) {
            Vector3 r = t.eulerAngles;
            r.x = x;
            t.rotation = Quaternion.Euler(r);
        }

        public static void SetEulerRotationY(this Transform t, float y) {
            Vector3 r = t.eulerAngles;
            r.y = y;
            t.rotation = Quaternion.Euler(r);
        }

        public static void SetEulerRotationZ(this Transform t, float z) {
            Vector3 r = t.eulerAngles;
            r.z = z;
            t.rotation = Quaternion.Euler(r);
        }

        // --- Local Scale ---
        public static void SetLocalScaleX(this Transform t, float x) {
            Vector3 s = t.localScale;
            s.x = x;
            t.localScale = s;
        }

        public static void SetLocalScaleY(this Transform t, float y) {
            Vector3 s = t.localScale;
            s.y = y;
            t.localScale = s;
        }

        public static void SetLocalScaleZ(this Transform t, float z) {
            Vector3 s = t.localScale;
            s.z = z;
            t.localScale = s;
        }

        public static void ResetLocalTransformation(this Transform trans) {
            trans.localPosition = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = new Vector3(1, 1, 1);
        }
    }
}
