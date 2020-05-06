using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cmCamera;
    [SerializeField] private float zoomMax = 8;
    [SerializeField] private float zoomMin = 1;

    private void Update() => Zoom(Input.GetAxis("Mouse ScrollWheel"));

    private void Zoom(float increment) => cmCamera.m_Lens.OrthographicSize = Mathf.Clamp(cmCamera.m_Lens.OrthographicSize - increment, zoomMin, zoomMax);
}
