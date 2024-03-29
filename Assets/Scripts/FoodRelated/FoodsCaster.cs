using UnityEngine;
using TMPro;

public class FoodsCaster : MonoBehaviour
{
    public Foods ApplePrefab;
    public Foods TeaPrefab;
    public Foods SaladPrefab;

    public int AppleCapacity = 10;
    public int TeaCapacity = 10;
    public int SaladCapacity = 10;

    public float Delay = 1.0f;

    public LayerMask FloorLayerMask;

    public TextMeshProUGUI uiTextApples;
    public TextMeshProUGUI uiTextTea;
    public TextMeshProUGUI uiTextSalad;


    private bool _isAppleInHands = true;
    private bool _isTeaInHands = false;
    private bool _isSaladInHands = false;

    private float _time = 0;

    private void Update()
    {
        ChangeFoodsInHands();
        DelayTiming();
        FoodCasting();
        Text();
    }

    public void Text()
    {
        uiTextApples.text = AppleCapacity.ToString();
        uiTextTea.text = TeaCapacity.ToString();
        uiTextSalad.text = SaladCapacity.ToString();
    }

    private void ChangeFoodsInHands()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _isAppleInHands = true;
            _isTeaInHands = false;
            _isSaladInHands = false;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            _isAppleInHands = false;
            _isTeaInHands = true;
            _isSaladInHands = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            _isAppleInHands = false;
            _isTeaInHands = false;
            _isSaladInHands = true;
        }
    }

    private void DelayTiming()
    {
        _time += Time.deltaTime;
    }

    private void FoodCasting()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, float.PositiveInfinity, FloorLayerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_time > Delay)
                {
                    if (_isAppleInHands)
                    {
                        if (AppleCapacity > 0)
                        {
                            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                            Foods food = Instantiate(ApplePrefab, transform.position, transform.rotation);
                            food.transform.LookAt(targetPosition);
                            _time = 0;
                            AppleCapacity -= 1;
                        }
                    }
                    if (_isTeaInHands)
                    {
                        if (TeaCapacity > 0)
                        {
                            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                            Foods food = Instantiate(TeaPrefab, transform.position, transform.rotation);
                            food.transform.LookAt(targetPosition);
                            _time = 0;
                            TeaCapacity -= 1;
                        }
                    }
                    if (_isSaladInHands)
                    {
                        if (SaladCapacity > 0)
                        {
                            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                            Foods food = Instantiate(SaladPrefab, transform.position, transform.rotation);
                            food.transform.LookAt(targetPosition);
                            _time = 0;
                            SaladCapacity -= 1;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }

    public void AppleReload()
    {
        if (AppleCapacity < 10)
        {
            AppleCapacity += 1;
        }
    }
    public void TeaReload()
    {
        if (TeaCapacity < 10)
        {
            TeaCapacity += 1;
        }
    }
    public void SaladReload()
    {
        if (SaladCapacity < 10)
        {
            SaladCapacity += 1;
        }
    }
}
