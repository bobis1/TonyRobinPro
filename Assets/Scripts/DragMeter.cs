using UnityEngine;

public class DragMeter : MonoBehaviour
{
    public Rigidbody rb;
    public RectTransform needle; // UI needle

    public float minDrag = 0f;
    public float maxDrag = 10f;

    public float leftAngle = -60f;
    public float rightAngle = 60f;

    public float zeroOffset = -90f; // <-- THIS is the fix
    public float smoothSpeed = 8f;

    void Update()
    {
        float drag = Mathf.Clamp(rb.drag, minDrag, maxDrag);

        float t = Mathf.InverseLerp(minDrag, maxDrag, drag);
        float angle = Mathf.Lerp(leftAngle, rightAngle, t);

        float finalAngle = angle + zeroOffset;

        Quaternion targetRotation = Quaternion.Euler(0, 0, finalAngle);

        needle.localRotation = Quaternion.Lerp(
            needle.localRotation,
            targetRotation,
            Time.deltaTime * smoothSpeed
        );
    }
}
