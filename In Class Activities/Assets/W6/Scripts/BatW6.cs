using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public float speed = 3f;
    private Transform _playerTarget;
    private bool _isChasing = false;
    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Cat");

        if (playerObject != null)
        {
            _playerTarget = playerObject.transform;
        }
        else
        {
            Debug.LogError("Bat could not find a game object named cat");
        }
    }
    void Update()
    {
        if (_isChasing && _playerTarget != null)
        {
            Vector3 direction = _playerTarget.position - transform.position;

            direction.Normalize();
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
    void StartChasingPlayer()
    {
        _isChasing = true;
    }
    void StopChasingPlayer()
    {
        _isChasing = false;
    }
}
