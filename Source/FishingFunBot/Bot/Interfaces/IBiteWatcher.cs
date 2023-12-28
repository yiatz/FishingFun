using System;
using System.Drawing;

namespace FishingFun
{
    public interface IBiteWatcher
    {
        void Reset(Point InitialBobberPosition);
        bool IsBite(Point currentBobberPosition);
        void SetStrikeValue(int strikeValue);
        int GetStrikeValue();

        Action<FishingEvent> FishingEventHandler { set; get; }
    }
}