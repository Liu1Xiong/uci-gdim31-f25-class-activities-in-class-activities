using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;

    private string _isWalkingName = "IsWalking";

    private void Update()
    {
        Vector3 translation = Vector3.zero;

        float verticalInput = Input.GetAxis("Vertical");

        if (verticalInput > 0.0f)
        {
            if (_flipWSControls)
            {
                transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
            }
            translation = Vector3.forward;
        }
        else if (verticalInput < 0.0f)
        {
            if (_flipWSControls)
            {
                transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
            }
        }
        // STEP 1 & 2 ---------------------------------------------------------

        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        if (translation.magnitude != 0.0f || rotation != 0.0f)
        {
            _animator.SetBool(_isWalkingName, true);
        }
        else
        {
            _animator.SetBool(_isWalkingName, false);
        }
    }
}
