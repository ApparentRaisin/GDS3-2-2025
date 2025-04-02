using UnityEngine;
//Gun script to shoot bullets
//shoots while holding down
//runs really badly! keeps causing slow downs with lots of bullets?
public class Gun : MonoBehaviour
{
    public Bullet bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Bullet tempBullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
            tempBullet.direction = Vector3.forward;
            tempBullet.player = this.transform;
        }
    }
}
