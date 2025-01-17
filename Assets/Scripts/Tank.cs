using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    public string verticalAxis;
    public string horizontalAxis;
    public KeyCode shootKey;

    public GameObject bullet;

    void Update()
    {
        var ver = Input.GetAxis(verticalAxis);
        transform.position += transform.forward * speed * ver * Time.deltaTime;

        var hor = Input.GetAxis(horizontalAxis);
        transform.Rotate(0,rotateSpeed * hor * Time.deltaTime,0);

        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet,transform.position,transform.rotation);
        }
    }
}