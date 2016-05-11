﻿using UnityEngine;

namespace PSI
{
    internal class PawnStats
    {
        public float PawnTotalEfficiency = 1f;

        public float PawnTooCold = -1f;

        public float PawnTooHot = -1f;

        public float PawnBleedRate = -1f;

        public float PawnPainRate = -1f;

        public Vector3 TargetPos = Vector3.zero;

        public float DiseaseDisappearance = 1f;

        public float PawnApparelHealth = 1f;

        public float PawnDrunkness;
    }
}