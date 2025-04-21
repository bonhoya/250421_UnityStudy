using UnityEngine;

public class TankController0421 : MonoBehaviour
{
    private float tankSpeed = 6;
    private float rotateSpeed = 30;
    private float tankRotateSpeed = 30;
    private Quaternion quaternionVector3;
    [SerializeField] TankShooter0421 tankShooter0421;
    private void Update()
    {
        Mover();
        HeadRotate();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tankShooter0421.Fire();
        }
    }

    private void Mover()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * tankSpeed * Time.deltaTime, Space.World);
            quaternionVector3 = Quaternion.LookRotation(Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, quaternionVector3, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * tankSpeed * Time.deltaTime, Space.World);
            quaternionVector3 = Quaternion.LookRotation(Vector3.back);
            transform.rotation = Quaternion.Lerp(transform.rotation, quaternionVector3, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * tankSpeed * Time.deltaTime, Space.World);
            quaternionVector3 = Quaternion.LookRotation(Vector3.right);
            transform.rotation = Quaternion.Lerp(transform.rotation, quaternionVector3, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * tankSpeed * Time.deltaTime, Space.World);
            quaternionVector3 = Quaternion.LookRotation(Vector3.left);
            transform.rotation = Quaternion.Lerp(transform.rotation, quaternionVector3, rotateSpeed * Time.deltaTime);
        }
    }

    private void HeadRotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            tankShooter0421.transform.Rotate(Vector3.up, -tankRotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            tankShooter0421.transform.Rotate(Vector3.up, tankRotateSpeed * Time.deltaTime);
        }

    }
}
