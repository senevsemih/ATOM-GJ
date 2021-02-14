using System;
using System.Collections;
using System.Collections.Generic;
using Assets.GJ.Scripts.Environment;
using UnityEngine;

namespace Assets.GJ.Scripts.Character
{
    public class CharacterManager : MonoBehaviour
    {
        [SerializeField] private CharacterSettings _boxSettings;
        [SerializeField] private CharacterSettings _stickSettings;

        private const float InputThreshHold = 0f;
        private const float Angle = 90f;

        private bool _isRolling;

        public CharacterStates States { get; private set; } = CharacterStates.Box;
        
        
        private void FixedUpdate()
        {
            switch (States)
            {
                case CharacterStates.Box:

                    transform.localScale = _boxSettings.Scale;
                    RollDirection(_boxSettings);
                    break;
                case CharacterStates.Stick:

                    transform.localScale = _stickSettings.Scale;
                    RollDirection(_stickSettings);
                    break;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (States == CharacterStates.Box)
                {
                    States = CharacterStates.Stick;
                }
                else if (States == CharacterStates.Stick)
                {
                    States = CharacterStates.Box;
                }
            }
        }

        private void RollDirection(CharacterSettings settings)
        {
            if (Input.GetKey(KeyCode.A) && !_isRolling)
            {
                StartCoroutine(Roll(settings.LeftDirection));
            }
            if (Input.GetKey(KeyCode.D) && !_isRolling)
            {
                StartCoroutine(Roll(settings.RightDirection));
            }
        }

        private IEnumerator Roll(Vector3 direction)
        {
            _isRolling = true;
            float angle = 0f;
            Vector3 point = transform.position + direction;
            Vector3 axis = Vector3.Cross(Vector3.up, direction).normalized;

            while (angle < 90f)
            {
                float angleSpeed = Time.deltaTime + _stickSettings.RollSpeed;
                transform.RotateAround(point, axis, angleSpeed);
                angle += angleSpeed;
                yield return null;
            }
            
            transform.RotateAround(point, axis, Angle - angle);
            _isRolling = false;
        }
    }
}

public enum CharacterStates
{   
    Stick,
    Box
}
