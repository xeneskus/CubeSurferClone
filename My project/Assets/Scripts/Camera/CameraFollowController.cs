using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float LerpValue;
    
    void Start()
    {
        offset = transform.position - heroTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.transform.position.z) + offset, LerpValue * Time.deltaTime);
        transform.position = newPosition;
    }

}
