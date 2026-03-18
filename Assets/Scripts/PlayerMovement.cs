using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float horizontalSpeed = 3f;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    [SerializeField] bool isRunning;

    void Update()
    {
        if(isRunning == false)
        {
            isRunning = true;
            StartCoroutine(AddDistance());
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
            }
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {

                transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
            }
        }
    }

    IEnumerator AddDistance()
    {
        yield return new WaitForSeconds(0.35f);
        MasterInfo.distancerun += 1;
        isRunning = false;
    }
}