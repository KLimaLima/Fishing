using UnityEngine;
using UnityEngine.XR;

public class XRInputExample : MonoBehaviour
{
    public int textNum;
    public bool wasButtonPressed = false;
    void Update()
    {
        // �{�^���̓��͂��擾
        bool isButtonPressed = CheckButtonInput();

        // �{�^���������ꂽ��ϐ�a�𑝉�������
        if (isButtonPressed && !wasButtonPressed)
        {
            textNum += 1; // Time.deltaTime���g���ăt���[�����[�g�Ɉˑ����Ȃ��悤�ɂ���
            Vector3 pos = transform.position;
            pos.x = 0;
            pos.y = 0.6f;
            pos.z = 1.56f;
            transform.position = pos;
            Debug.Log("Button Pressed! a = " + textNum);
        }
        wasButtonPressed = isButtonPressed;
    }

    public bool CheckButtonInput()
    {
        // OpenXR���g�p���ă{�^���̓��͂��擾����
        // �����ł͗�Ƃ���PrimaryButton�i��̓I�ȃ{�^���̓v���W�F�N�g�̐ݒ�Ɉˑ����܂��j�̏�Ԃ��m�F���Ă��܂��B
        // OpenXR API�̋�̓I�Ȏg�p���@�̓v���O�C���̃h�L�������g��OpenXR�̃h�L�������g���Q�Ƃ��Ă��������B
        InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand); // �E��̃f�o�C�X������
        bool isButtonPressed = false;
        if (device.TryGetFeatureValue(CommonUsages.primaryButton, out isButtonPressed) && isButtonPressed)
        {
            return true;
        }
        return false;
    }
}