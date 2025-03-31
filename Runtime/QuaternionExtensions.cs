using UnityEngine;

namespace CMIV.UnityExtensionMethods
{
    public static class QuaternionExtensions
    {
        public static float GetAngleAroundAxis(this Quaternion q, Vector3 axis) {
            axis.Normalize();

            // Wähle einen Vektor, der nicht parallel zur Achse ist
            Vector3 reference = Vector3.Cross(axis, Vector3.up);
            if (reference.sqrMagnitude < 0.01f)
                reference = Vector3.Cross(axis, Vector3.right);

            reference.Normalize();

            // Dreh den Referenzvektor mit dem Quaternion
            Vector3 rotated = q * reference;

            // Winkel zwischen Original und gedrehtem Vektor (um die Achse)
            float angle = Vector3.SignedAngle(reference, rotated, axis);
            return angle;
        }
    }
}
