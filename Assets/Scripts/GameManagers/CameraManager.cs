using System.Collections;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance;

    private Camera _camera;
    [SerializeField] private Transform[] _cameraTransforms;
    [SerializeField] private int _cameraIndex = 0;
    [SerializeField] private float _cameraLerpDuration = .5f;

    private bool _cameraIsTransitioning = false;

    private void Awake()
    {
        _camera = Camera.main;
        
        StartCoroutine(ApplyCameraTransform(_cameraIndex));
        
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void ChangeCameraTransform(float sign)
    {
        if(sign < 0 && _cameraIndex != 0)
        {
            _cameraIndex--;
        }
        else if(sign > 0 && _cameraIndex != _cameraTransforms.Length - 1)
        {
            _cameraIndex++;
        }
        StartCoroutine(ApplyCameraTransform(_cameraIndex));
    }

    private IEnumerator ApplyCameraTransform(int index)
    {
        if (_cameraIsTransitioning)
            yield break;

        _cameraIsTransitioning = true;
        float duration = _cameraLerpDuration;
        float elapsed = 0f;

        Vector3 startPosition = _camera.transform.position;
        Quaternion startRotation = _camera.transform.rotation;

        Transform target = _cameraTransforms[(int)index];
        
        while (elapsed < duration)
        {
            float t = elapsed / duration;

            _camera.transform.position = Vector3.Lerp(startPosition, target.position, t);
            _camera.transform.rotation = Quaternion.Lerp(startRotation, target.rotation, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // JUST SET FINALIZE THE TARGET VALUES TO ASSURE THE TRANSITION DOES NOT MISS ANY DECIMALS
        _camera.transform.position = target.position;
        _camera.transform.rotation = target.rotation;

        _cameraIsTransitioning = false;

    }
}
