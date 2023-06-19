using Godot;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Yarn.GodotYarn {
    public class WaitForSeconds {
        private float _duration;
        private double _timer = 0;

        public WaitForSeconds(float t) {
            _duration = t;
        }

        public bool Tick(double t) {
            _timer += t;

            // GD.Print($"Timer: {_timer} Duration: {_duration}");

            if (_timer >= _duration) {
                _timer -= _duration;
                return true;
            }

            return false;
        }
    }
}