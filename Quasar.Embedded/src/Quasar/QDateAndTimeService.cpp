#include "QBle.h"
#include "QTypes.h"
#include "QDisplay.h"

#include <string>
#include <Particle.h>

namespace Quasar
{
    #pragma region Time characteristic

    struct TimeData
    {
        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;
    };

    static TimeData s_TimeData;

    void TimeDataReceived(const uint8_t* pData, size_t len, const BlePeerDevice& peer, void* pContext)
    {
        if (pContext == Uuid::TimeCharacteristic)
        {
           char hours[2] {};
           char minutes[2] {};
           char seconds[2] {};

           std::memcpy(hours, pData, 2);
           std::memcpy(minutes, pData + 3, 2);
           std::memcpy(seconds, pData + 6, 2);

           s_TimeData.Hours = atoi(hours);
           s_TimeData.Minutes = atoi(minutes);
           s_TimeData.Seconds = atoi(seconds);
        }
    }

    void TimeDisplayPresenter(Adafruit_SSD1306* pDisplay)
    {
        pDisplay->printf("%d:%d:%d", s_TimeData.Hours, s_TimeData.Minutes, s_TimeData.Seconds);
    }

    QUASAR_THREAD_INIT(time_thread, 
    { SetPresenter(TimeDisplayPresenter); },

    {
        delay(1000);
        s_TimeData.Seconds++;

        if (s_TimeData.Seconds > 59)
        {
            s_TimeData.Minutes++;
            s_TimeData.Seconds = 0;
        }
        if (s_TimeData.Minutes > 59)
        {
            s_TimeData.Hours++;
            s_TimeData.Minutes = 0;
        }
        if (s_TimeData.Hours > 59)
        {
            s_TimeData.Hours = 0;
        }
    });

    #pragma endregion

    #pragma region Date characteristic

    void DateDataReceived(const uint8_t* pData, size_t len, const BlePeerDevice& peer, void* pContext)
    {

    }

    #pragma endregion
}