using UnityEngine;

public class XRCameraController : MonoBehaviour {
  public const float METERS_SCALE = 1.0f;
  public const float FEET_SCALE = 3.28084f;

  
  private XRController xr;
  private bool initialized = false;

  public bool _slow;

  // XRCameraController.scale allows for scaling the effective units of a scene. For example, if
  // feet is a more natural unit for a scene than meters, set scale to 3.28084f.
  public float scale = METERS_SCALE;

  void OnEnable() {
    xr = GameObject.FindWithTag("XRController").GetComponent<XRController>();
    xr.UpdateCameraProjectionMatrix(
      GetComponent<Camera>(), transform.position, transform.rotation, scale);
    if (!xr.DisabledInEditor()) {
      initialized = true;
    }
  }

  void Initialize() {
    initialized = true;
    xr.UpdateCameraProjectionMatrix(
      GetComponent<Camera>(), transform.position, transform.rotation, scale);
  }

  void Update () {
    if (xr.DisabledInEditor()) {
      return;
    }
    if (!initialized) {
      Initialize();
    }
    if (_slow)
    {
      transform.position = Vector3.Lerp(transform.position,xr.GetCameraPosition(),Time.deltaTime*10);
      transform.rotation = Quaternion.Lerp(transform.rotation,xr.GetCameraRotation(),Time.deltaTime*10);
      return;
    }
    transform.position = xr.GetCameraPosition();
    transform.rotation = xr.GetCameraRotation();
  }
}
