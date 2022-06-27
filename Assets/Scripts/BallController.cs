using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countScore;
    [SerializeField] private Text Timeleft;
    public int Duration;
    private int remaingDuration;
    [SerializeField] Joystick joystick;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip Clip_CoinPickup;

  //  [SerializeField] private GameObject _BonusItems;

    private Rigidbody _rb;
    private int _count;

    // Start is called before the first frame update
    private void Start()
    {
        Timer(Duration);
        _rb = GetComponent<Rigidbody>();
        _count = 0;
        SetCountScore();
    }

    void SetCountScore()
    {
        countScore.text = "Score : " + _count.ToString();
        if (_count >= 210)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(2);        
        }
    }

    // Update is called once per frame
    private void Update()
    {
        float _movementX = Input.GetAxis("Horizontal");
        float _movementY = Input.GetAxis("Vertical");
        
         float movementX = joystick.Horizontal;
         float movementY = joystick.Vertical;
        

        Vector3 movement = new Vector3(_movementX, 0.0f, _movementY);       
        _rb.AddForce(movement * speed * Time.deltaTime, ForceMode.Impulse);

        Vector3 jmovement = new Vector3(movementX, 0.0f, movementY);
        _rb.AddForce(jmovement * speed * Time.deltaTime, ForceMode.Impulse);

        if (remaingDuration <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(3);           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickableItems"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 10;
            SetCountScore();
            source.PlayOneShot(Clip_CoinPickup);
        }
/*
        if (_count >= 100)
        {           
             Instantiate(_BonusItems, RandomPos(), Quaternion.identity);                       
        }

        if (other.gameObject.CompareTag("BonusItem"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 50;
            SetCountScore();
        }
*/
    }
    private void Timer(int Second)
    {
        remaingDuration = Second;
        StartCoroutine(UpdateTimer());
    }
    private IEnumerator UpdateTimer()
    {
        while (remaingDuration >= 0)
        {
            Timeleft.text = $"{remaingDuration / 60:00} : {remaingDuration % 60:00}";
            remaingDuration--;
            yield return new WaitForSeconds(1f);
        }
    }
/*
    private Vector3 RandomPos()
    {
        int x, z;
        float y;

        x = Random.Range(-22, 22);
        y = 1.5f;
        z = Random.Range(-22, 22);

        return new Vector3(x, y, z);

    }
*/

}