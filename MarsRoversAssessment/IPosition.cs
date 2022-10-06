using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoversAssessment
{
    public interface IPosition
    {
        void DoTheMovement(List<int> maxCoordinates, string moves);
    }
}
