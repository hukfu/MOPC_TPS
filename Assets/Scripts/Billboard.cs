using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera m_Camera = null;
    public bool m_RotateAroundVertical = false;

    private void Awake()
    {
        if (!m_Camera)
        {
            m_Camera = Camera.main;
        }
    }

    private void LateUpdate()
    {
        if (m_RotateAroundVertical)
        {
            Vector3 cameraForwardXZ = Vector3.ProjectOnPlane(m_Camera.transform.forward, Vector3.up).normalized;
            transform.LookAt(transform.position - cameraForwardXZ);
        }
        else
        {
            transform.LookAt(transform.position - m_Camera.transform.forward, m_Camera.transform.rotation * Vector3.up);
        }
    }
}
