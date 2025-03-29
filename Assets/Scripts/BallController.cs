using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveForce = 5f; // กำหนดแรงผลัก
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ดึง Rigidbody ของลูกบอล
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // รับค่า A/D หรือ ลูกศรซ้าย/ขวา
        float moveZ = Input.GetAxis("Vertical");   // รับค่า W/S หรือ ลูกศรขึ้น/ลง

        Vector3 force = new Vector3(moveX, 0, moveZ) * moveForce;
        rb.AddForce(force); // เพิ่มแรงให้ลูกบอลเคลื่อนที่
    }
}