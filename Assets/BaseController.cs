using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {

  public Transform firePoint;
  public GameObject missilePrefab;

  // Start is called before the first frame update
  void Start() {
    Debug.Log("Hello World");
  }

  // Update is called once per frame
  void Update() {
    if(Input.GetKeyDown(KeyCode.W)) {
      Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
    }
  }
}
